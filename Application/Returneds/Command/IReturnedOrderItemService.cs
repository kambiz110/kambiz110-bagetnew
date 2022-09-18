using Application.Dtos;
using Application.Interfaces.Contexts;
using Domain.Order;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Returneds.Command
{
    public interface IReturnedOrderItemService
    {
        ResultDto ReturnedOrderItem(int[] orderItemsIds, int orederId , string userId);

    }
    public class ReturnedOrderItemService : IReturnedOrderItemService
    {
        private readonly IDataBaseContext context;

        public ReturnedOrderItemService(IDataBaseContext context)
        {
            this.context = context;
        }

        public ResultDto ReturnedOrderItem(int[] orderItemsIds, int orederId, string userId)
        {
            var order = context.Orders.Where(p => p.Id == orederId /*&& p.ZamanDelivered!=null && p.ZamanDelivered>DateTime.Now.AddDays(-5)*/)
                        .Include(p => p.OrderItems.Where(p => orderItemsIds.Contains(p.Id)))
                        .OrderByDescending(p => p.Id).FirstOrDefault();

            if (order != null && order.OrderItems != null && order.OrderItems.Any())
            {
                Returned returned = new Returned
                {
                    UserId= userId,
                    OrderId = orederId,
                };
                Random random = new Random();
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                var rand = new string(Enumerable.Repeat(chars, 6)
                     .Select(s => s[random.Next(s.Length)]).ToArray());
                context.Returneds.Add(returned);
                context.SaveChanges();

                returned.FollowKey = $"RYCSH-{rand}-{returned.Id}";
                context.Returneds.Update(returned);
                context.SaveChanges();
                foreach (var item in order.OrderItems)
                {
                    ReturneOrderItem returnedItems = new ReturneOrderItem
                    {
                        ReturnedId = returned.Id,
                        OrderItemId = item.Id,
                    };
                    item.OrderItemReturned();
                    context.ReturneOrderItems.Add(returnedItems);
                }
                context.SaveChanges();
                return new ResultDto { IsSuccess = true };
            }
            return new ResultDto { IsSuccess = false };
        }
    }
}
