using Application.Interfaces.Contexts;
using Application.Orders.CustomerOrdersServices;
using Application.Orders.Dto;
using Application.PostalProducts.Dto;
using AutoMapper;
using Domain.Order;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Orders.AdminOrderServices
{
    public interface IAdminOrdersService
    {
        OderDitalesForAdminDto GetAdminOrderDitales(Guid PaymentId);
        //OderDitalesForAdminDto GetAdminOrderDitalesForPrint(Guid PaymentId);
        List<MyOrderDto> GetShopAdminOrder(string searchkey,int orderStatus);
    }

    public class AdminOrdersService : IAdminOrdersService
    {

        private readonly IIdentityDatabaseContext identityDatabase;
        private readonly IDataBaseContext context;
        private readonly IMapper mapper;

        public AdminOrdersService(IDataBaseContext context, IMapper mapper, IIdentityDatabaseContext identityDatabase)
        {
            this.context = context;
            this.mapper = mapper;
            this.identityDatabase = identityDatabase;
        }

        public OderDitalesForAdminDto GetAdminOrderDitales(Guid PaymentId)
        {
            var payment = context.Payments.Where(p => p.Id == PaymentId)
                 .Include(p => p.Order).ThenInclude(p => p.OrderItems.Where(p => (int)p.OrderItemStatus == 0))
                 .Include(p => p.Order).ThenInclude(p => p.PostProduct)
             
                 .FirstOrDefault();
            var user = identityDatabase.Users.FirstOrDefault(p=>p.Id== payment.Order.UserId);
            if (payment!=null && user!=null)
            {
                var model = new OderDitalesForAdminDto
                {
                    postalProductDto=payment.Order.PostProduct!=null?mapper.Map<AddPostalProductDto>(payment.Order.PostProduct):new AddPostalProductDto { },
                    Address =payment.Order.Address,
                    Amount= payment.Order.TotalPriceWithPostalDelivery(),
                    userePhoneNumber=user.PhoneNumber,
                    usereFullname=user.FullName,
                    FollowKey=payment.Order.FollowKey,
                    OrderId=payment.Order.Id,
                    Date=payment.Order.ZamanSabt,
                    OrderStatus=payment.Order.OrderStatus,
                    OrederItems=payment.Order.OrderItems.Select(o=> new OrederItemsForOrderDto {
                    Id=o.Id,
                    CatalogItemid=o.CatalogItemId,
                    ProductName=o.ProductName,
                    UnitPrice=o.UnitPrice,
                    Units=o.Units
                 
                    }).ToList(),
                    PaymentId= PaymentId                   
                };
                return model;
            }
            return null;
        }

        public List<MyOrderDto> GetShopAdminOrder(string searchkey, int orderStatus)
        {


            var orders = context.Orders.Where(p=>((int)p.OrderStatus)== orderStatus)
                .Include(p => p.OrderItems.Where(p=>(int)p.OrderItemStatus==0))
                .OrderByDescending(p => p.Id).AsQueryable();
            if (!String.IsNullOrEmpty(searchkey))
            {
                orders = orders.Where(p => p.Address.ReciverName.Contains(searchkey.Trim())
                 || p.Address.PhoneNumber.Contains(searchkey.Trim())
                  || p.Address.PostalAddress.Contains(searchkey.Trim())).AsQueryable();
            }
            var result = orders.ToList()
                .Select(p => new MyOrderDto
                {
                    Id = p.Id,
                    Date = p.ZamanSabt,
                    OrderStatus = p.OrderStatus,
                    PaymentStatus = p.PaymentStatus,
                    Price = p.OrderItems.Sum(o => o.UnitPrice * o.Units),
                    countOrderItems=p.OrderItems.Count(),
                    PaymentId=context.Payments.FirstOrDefault(m=>m.OrderId==p.Id)?.Id

                }).ToList();
            return result;
        }
    }
}
