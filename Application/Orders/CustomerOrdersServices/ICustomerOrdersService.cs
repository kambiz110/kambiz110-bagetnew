using Application.Interfaces.Contexts;
using Application.Orders.Dto;
using Application.PostalProducts.Dto;
using Application.Returneds.Dto;
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
        GetMyTaskeInOrderDto GetMyOrder(string userId);
        Task chengeOrederStatuse(int orderId, int status, string userId);

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
            var order = context.Orders.Where(p => p.UserId == userId && p.Id == orderId).FirstOrDefault();
            if (order != null)
            {
                switch (status)
                {
                    case 3:
                        order.OrderCancelled();
                        break;
                    case 4:
                        order.OrderPostOfficalDelivered();
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

        public GetMyTaskeInOrderDto GetMyOrder(string userId)
        {
            var model = new GetMyTaskeInOrderDto();
            var orders = context.Orders.Where(p => p.UserId == userId)
                .Include(p => p.OrderItems.Where(p => p.OrderItemStatus == 0))

                .OrderByDescending(p => p.Id).ToList()
                .Where(p => p.OrderItems != null && p.OrderItems.Any());
            var resultorders = orders
                .Select(p => new MyOrderDto
                {
                    Id = p.Id,
                    Date = p.ZamanSabt,
                    OrderStatus = p.OrderStatus,
                    PaymentStatus = p.PaymentStatus,
                    Price = p.OrderItems.Sum(o => o.UnitPrice * o.Units),
                    PaymentId = context.Payments.FirstOrDefault(m => m.OrderId == p.Id)?.Id,
                    FollowKey = p.FollowKey

                }).ToList();


            var returneds = context.Returneds.Where(p => p.UserId == userId)
      .Include(p => p.ReturneOrderItems).ThenInclude(p => p.OrderItem)
      .OrderByDescending(p => p.Id)
      .Select(p => new MyReturnedDto
      {
          Date = p.InsertTime,
          OrderId = p.OrderId,
          Price = p.ReturneOrderItems.Select(o => new
          {
              pricc = o.OrderItem.UnitPrice * o.OrderItem.Units,
          }).FirstOrDefault().pricc,
          countOrderItems = p.ReturneOrderItems.Count(),
          ReturnedId = p.Id,
          ReturnedStatus = p.ReturnedStatus,
      })
      .ToList();
            model.GetMyReturneds = returneds;
            model.GetMyOrders = resultorders;
            return model;
        }
    }
    public class GetMyTaskeInOrderDto
    {
        public List<MyOrderDto> GetMyOrders { get; set; }
        public List<MyReturnedDto> GetMyReturneds { get; set; }
    }
    public class MyOrderDto
    {
        public Guid? PaymentId { get; set; }
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int countOrderItems { get; set; } = 0;

        public int Price { get; set; }
        public string FollowKey { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
    }

}
