using Application.Interfaces.Contexts;
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

namespace Application.Orders.CustomerOrdersServices
{
    public interface ICustomerOrdersService
    {
        List<MyOrderDto> GetMyOrder(string userId);
        Task chengeOrederStatuse(int orderId , int status, string userId);

        OderDitalesForCustomerDto GetCustomerOrderDitales(Guid PaymentId);
    }

    public class CustomerOrdersService : ICustomerOrdersService
    {
        private readonly IIdentityDatabaseContext identityDatabase;
        private readonly IDataBaseContext context;
        private readonly IMapper mapper;



        public CustomerOrdersService(IIdentityDatabaseContext identityDatabase, IDataBaseContext context, IMapper mapper)
        {
            this.identityDatabase = identityDatabase;
            this.context = context;
            this.mapper = mapper;
        }

        public async Task chengeOrederStatuse(int orderId, int status, string userId)
        {
            var order = context.Orders.Where(p => p.UserId == userId &&p.Id==orderId).FirstOrDefault();
            if (order!=null)
            {
                switch (status)
                {
                    case 4:
                        order.OrderRequestReturned();
                        break;
                    case 5:
                        order.OrderReturned();
                        break;
                    default:
                        break;
                }
               await context.SaveChangesAsync();
               
            }
          
        }

        public OderDitalesForCustomerDto GetCustomerOrderDitales(Guid PaymentId)
        {
            var payment = context.Payments.Where(p => p.Id == PaymentId)
          .Include(p => p.Order).ThenInclude(p => p.OrderItems.Where(p => p.OrderItemStatus == 0))
          .Include(p => p.Order).ThenInclude(p => p.PostProduct)

          .FirstOrDefault();
            var user = identityDatabase.Users.FirstOrDefault(p => p.Id == payment.Order.UserId);
            if (payment != null && user != null)
            {
                var model = new OderDitalesForCustomerDto
                {
                    postalProductDto = payment.Order.PostProduct != null ? mapper.Map<AddPostalProductDto>(payment.Order.PostProduct) : new AddPostalProductDto { },
                    Address = payment.Order.Address,
                    Amount = payment.Order.OrderItems.Sum(o => o.UnitPrice * o.Units),
                    OrderId = payment.Order.Id,
                    Date = payment.Order.ZamanSabt,
                    OrderStatus = payment.Order.OrderStatus,
                    OrederItems = payment.Order.OrderItems.Select(o => new OrederItemsForOrderDto
                    {
                        Id = o.Id,
                        CatalogItemid = o.CatalogItemId,
                        ProductName = o.ProductName,
                        UnitPrice = o.UnitPrice,
                        Units = o.Units

                    }).ToList(),
                    PaymentId = PaymentId
                };
                return model;
            }
            return null;
        }

        public List<MyOrderDto> GetMyOrder(string userId)
        {
 
            var orders = context.Orders.Where(p => p.UserId == userId)
                .Include(p => p.OrderItems.Where(p=>p.OrderItemStatus==0))
                
                .OrderByDescending(p => p.Id).ToList()
                .Where(p => p.OrderItems != null && p.OrderItems.Any());
            var result = orders
                .Select(p => new MyOrderDto
                {
                    Id = p.Id,
                    Date = p.ZamanSabt,
                    OrderStatus = p.OrderStatus,
                    PaymentStatus = p.PaymentStatus,
                    Price = p.OrderItems.Sum(o=>o.UnitPrice*o.Units),
                    PaymentId=context.Payments.FirstOrDefault(m=>m.OrderId==p.Id)?.Id,
                    FollowKey=p.FollowKey

                }).ToList();
            return result;
        }
    }

    public class MyOrderDto
    {
        public Guid? PaymentId { get; set; }
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Price { get; set; }
        public string FollowKey { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
    }

}
