using Application.Interfaces.Contexts;
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
    }

    public class CustomerOrdersService : ICustomerOrdersService
    {

        private readonly IDataBaseContext context;

        public CustomerOrdersService(IDataBaseContext context)
        {
            this.context = context;
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
                        order.OrderRequestCancelled();
                        break;
                    default:
                        break;
                }
               await context.SaveChangesAsync();
               
            }
          
        }

        public List<MyOrderDto> GetMyOrder(string userId)
        {
 
            var orders = context.Orders.Where(p => p.UserId == userId)
                .Include(p => p.OrderItems)
                
                .OrderByDescending(p => p.Id).ToList();
            var result = orders
                .Select(p => new MyOrderDto
                {
                    Id = p.Id,
                    Date = p.ZamanSabt,
                    OrderStatus = p.OrderStatus,
                    PaymentStatus = p.PaymentStatus,
                    Price = p.TotalPrice(),
                    PaymentId=context.Payments.FirstOrDefault(m=>m.OrderId==p.Id)?.Id

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
        public OrderStatus OrderStatus { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
    }

}
