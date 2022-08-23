using Application.Interfaces.Contexts;
using Application.Orders.CustomerOrdersServices;
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
        List<MyOrderDto> GetShopOrder(string searchkey);
    }

    public class AdminOrdersService : IAdminOrdersService
    {

        private readonly IDataBaseContext context;

        public AdminOrdersService(IDataBaseContext context)
        {
            this.context = context;
        }

        public List<MyOrderDto> GetShopOrder(string searchkey)
        {


            var orders = context.Orders.AsNoTracking()
                .Include(p => p.OrderItems)
                .Where(p =>p.PaymentStatus== Domain.Order.PaymentStatus.Paid && p.OrderStatus== Domain.Order.OrderStatus.Processing)
                .OrderByDescending(p => p.Id)
                .Select(p => new MyOrderDto
                {
                    Id = p.Id,
                    Date = p.ZamanSabt,
                    OrderStatus = p.OrderStatus,
                    PaymentStatus = p.PaymentStatus,
                    Price = p.TotalPrice()

                }).ToList();
            return orders;
        }
    }
}
