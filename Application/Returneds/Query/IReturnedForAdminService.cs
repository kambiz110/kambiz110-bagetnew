using Application.Interfaces.Contexts;
using Application.Orders.Dto;
using Application.PostalProducts.Dto;
using Application.Returneds.Dto;
using Application.ReturnPaymentInvoice.Dto;
using AutoMapper;
using Domain.Order;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Returneds.Query
{
    public interface IReturnedForAdminService
    {
        /// <summary>
        /// مشخص نمودن وضعیت محصول مرجوعی به فروشگاه
        /// </summary>
        /// <param name="dto"></param>
       void StatusResiveReturnedToShop(ResiveOrderItemsReturnedDto dto);
        List<MyReturnedDto> GetMyReturneds(int status);
        GetReturnedDitalesForAdminDto GetAdminOrderDitales(int returnedId);
       void CanseleReturnProductes (canseleReturnProductesDto data);
    }
    public class ReturnedForAdminService : IReturnedForAdminService
    {
        private readonly IIdentityDatabaseContext identityDatabase;
        private readonly IDataBaseContext context;
        private readonly IMapper mapper;

        public ReturnedForAdminService(IIdentityDatabaseContext identityDatabase,IDataBaseContext context, IMapper mapper)
        {
            this.identityDatabase = identityDatabase;
            this.context = context;
            this.mapper = mapper;
        }

        public void CanseleReturnProductes(canseleReturnProductesDto data)
        {
            var returned = context.Returneds.Where(p => p.Id == data.ReturnedId)
        .Include(p => p.ReturneOrderItems).FirstOrDefault();
            returned.ReturnedStatus = ReturnedStatus.Returned;
            var orderItems = context.OrderItems.Where(p => returned.ReturneOrderItems.Select(p => p.OrderItemId).Contains(p.Id)).ToList();
            context.Returneds.Remove(returned);
            for (int i = 0; i < orderItems.Count(); i++)
            {
            orderItems.ElementAt(i).OrderItemSelered();
            }
            context.SaveChanges();
        }

        public GetReturnedDitalesForAdminDto GetAdminOrderDitales(int returnedId)
        {
            var returned = context.Returneds.Where(p => p.Id == returnedId)
                 .Include(p => p.ReturneOrderItems).ThenInclude(p => p.OrderItem)
                 .Include(p => p.ReturnedProduct)
                   .Include(p => p.Order).ThenInclude(p=>p.OrderItems.Where(p=>(int)p.OrderItemStatus==1))
                .FirstOrDefault();
            if (returned!=null)
            {
                var user = identityDatabase.Users.FirstOrDefault(p => p.Id == returned.UserId);

                var model = new GetReturnedDitalesForAdminDto
                {
                    ReturnedId=returned.Id,
                    userePhoneNumber=user.PhoneNumber,
                    postalProductDto = returned.ReturnedProduct != null ? mapper.Map<AddReturnedPostalProductDto>(returned.ReturnedProduct) : new AddReturnedPostalProductDto { },
                    Address = returned.Order.Address,
                    Amount = returned.Order.OrderItems.Sum(o => o.UnitPrice * o.Units),
                    OrderId = returned.Order.Id,
                    Date = returned.InsertTime,
                    RecivePostDate = returned.ReturnedProduct?.ReciveDate,
                    PostDate =returned.ReturnedProduct?.InsertDate,
                    ReturnedStatus = returned.ReturnedStatus,
                    OrederItems = returned.Order.OrderItems.Where(p => (int)p.OrderItemStatus == 1).Select(o => new OrederItemsForOrderDto
                    {
                        Id = o.Id,
                        CatalogItemid = o.CatalogItemId,
                        ProductName = o.ProductName,
                        UnitPrice = o.UnitPrice,
                        Units = o.Units,
                  
                      ItemStatus=returned.ReturneOrderItems.FirstOrDefault(p=>p.OrderItemId==o.Id).ItemStatus

                    }).ToList()
                   
                };
                return model;
            }
            return null;
        }

        public List<MyReturnedDto> GetMyReturneds(int status)
        {
            var returneds = context.Returneds.Where(p => (int)p.ReturnedStatus == status)
                .Include(p => p.ReturneOrderItems).ThenInclude(p => p.OrderItem)
                .OrderByDescending(p => p.Id).ToList();
                var result = returneds
                .Select(p => new MyReturnedDto
                {
                    Date = p.InsertTime,
                    OrderId = p.OrderId,
                    Price = p.ReturneOrderItems.Select(o => new
                    {
                        pricc = o.OrderItem.UnitPrice * o.OrderItem.Units
                    }).FirstOrDefault().pricc,
                    countOrderItems = p.ReturneOrderItems.Count(),
                    ReturnedId = p.Id,
                    ReturnedStatus = p.ReturnedStatus,
                })
                .ToList();
            return result;
        }

        public void StatusResiveReturnedToShop(ResiveOrderItemsReturnedDto dto)
        {
            var returned = context.Returneds.Where(p => p.Id == dto.ReturnedId)
                .Include(p => p.ReturneOrderItems).FirstOrDefault();
            returned.ReturnedStatus = ReturnedStatus.Returned;
            foreach (var item in dto.OrderItemsReturnedDtos)
            {
             var returneOrderItem =   returned.ReturneOrderItems.Where(p => p.ReturnedId == dto.ReturnedId && p.OrderItemId == item.Id).FirstOrDefault();
                if (returneOrderItem!=null)
                {
                    returneOrderItem.ItemStatus = (ReturneOrderItemStatus)item.ReturneOrderItemStatus;
                }
            }
            context.SaveChanges();
     
        }
    }
}
