using Application.Interfaces.Contexts;
using Application.Orders.Dto;
using Application.Returneds.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Returneds.Query
{
   public interface IReturnedForCustomerService
    {
        GetReturnedForCustomerDto GetCustomerOrderDitales(int returnedId , string userId);
    }
    public class ReturnedForCustomerService : IReturnedForCustomerService
    {
        private readonly IDataBaseContext context;

        public ReturnedForCustomerService(IDataBaseContext context)
        {
            this.context = context;
        }

        public GetReturnedForCustomerDto GetCustomerOrderDitales(int returnedId, string userId)
        {
            var returned = context.Returneds.AsNoTracking().Where(p => p.Id == returnedId && p.UserId == userId)
                .Include(p => p.ReturneOrderItems).ThenInclude(p=>p.OrderItem).AsNoTracking()
                 .Include(p => p.Order).AsNoTracking()
                .FirstOrDefault();
            if (returned!=null)
            {
                var model = new GetReturnedForCustomerDto {
                    Address = returned.Order.Address,
                    Amount= returned.ReturneOrderItems.Select(o => new
                    {
                        pricc = o.OrderItem.UnitPrice * o.OrderItem.Units
                    }).ToList().Sum(p=>p.pricc),
                    OrderId = returned.Order.Id,
                    Date = returned.InsertTime,
                    ReturnedStatus = returned.ReturnedStatus,
                    ReturnedId= returned.Id,
                    OrederItems = returned.ReturneOrderItems.Select(o => new OrederItemsForOrderDto
                    {
                        Id = o.Id,
                        CatalogItemid = o.OrderItem.CatalogItemId,
                        ProductName = o.OrderItem.ProductName,
                        UnitPrice = o.OrderItem.UnitPrice,
                        Units = o.OrderItem.Units

                    }).ToList(),
                };
                return model;
            }
            return null;
        }
    }
}
