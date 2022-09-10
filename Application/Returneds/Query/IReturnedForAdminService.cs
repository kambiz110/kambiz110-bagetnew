using Application.Interfaces.Contexts;
using Application.Orders.Dto;
using Application.PostalProducts.Dto;
using Application.Returneds.Dto;
using AutoMapper;
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
        List<MyReturnedDto> GetMyReturneds(int status);
        GetReturnedDitalesForAdminDto GetAdminOrderDitales(int returnedId);
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

        public GetReturnedDitalesForAdminDto GetAdminOrderDitales(int returnedId)
        {
            var returned = context.Returneds.Where(p => p.Id == returnedId)
                 .Include(p => p.ReturneOrderItems).ThenInclude(p => p.OrderItem)
                 .Include(p => p.PostProduct)
                   .Include(p => p.Order).ThenInclude(p=>p.OrderItems)
                .FirstOrDefault();
            if (returned!=null)
            {
                var user = identityDatabase.Users.FirstOrDefault(p => p.Id == returned.UserId);

                var model = new GetReturnedDitalesForAdminDto
                {
                    ReturnedId=returned.Id,
                    userePhoneNumber=user.PhoneNumber,
                    postalProductDto = returned.Order.PostProduct != null ? mapper.Map<AddPostalProductDto>(returned.Order.PostProduct) : new AddPostalProductDto { },
                    Address = returned.Order.Address,
                    Amount = returned.Order.OrderItems.Sum(o => o.UnitPrice * o.Units),
                    OrderId = returned.Order.Id,
                    Date = returned.InsertTime,
                    RecivePostDate = returned.PostProduct?.ReciveDate,
                    PostDate =returned.PostProduct?.InsertDate,
                    ReturnedStatus = returned.ReturnedStatus,
                    OrederItems = returned.Order.OrderItems.Select(o => new OrederItemsForOrderDto
                    {
                        Id = o.Id,
                        CatalogItemid = o.CatalogItemId,
                        ProductName = o.ProductName,
                        UnitPrice = o.UnitPrice,
                        Units = o.Units

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
                .OrderByDescending(p => p.Id)
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
            return returneds;
        }
    }
}
