using Application.Interfaces.Contexts;
using Application.Orders.CustomerOrdersServices;
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
        List<MyOrderDto> GetShopOrder(string searchkey,int orderStatus);
    }

    public class AdminOrdersService : IAdminOrdersService
    {

        private readonly IDataBaseContext context;

        public AdminOrdersService(IDataBaseContext context)
        {
            this.context = context;
        }

        public List<MyOrderDto> GetShopOrder(string searchkey, int orderStatus)
        {


            var orders = context.Orders.Where(p=>((int)p.OrderStatus)== orderStatus)
                .Include(p => p.OrderItems)
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
                    Price = p.TotalPrice(),
                    PaymentId=context.Payments.FirstOrDefault(m=>m.OrderId==p.Id)?.Id

                }).ToList();
            return result;
        }
    }
}
