using Application.Catalogs.CatalogItems.UriComposer;
using Application.Discounts;
using Application.Interfaces.Contexts;
using AutoMapper;
using Common.Useful;
using Domain.Order;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Orders
{
    public interface IOrderService
    {
        int CreateOrder(int BasketId, int UserAddressId, PaymentMethod paymentMethod);
    }

    public class OrderService : IOrderService
    {

        private readonly IDataBaseContext context;
        private readonly IMapper mapper;
      
        private readonly IDiscountHistoryService discountHistoryService;

        public OrderService(IDataBaseContext context
            , IMapper mapper
           
            , IDiscountHistoryService discountHistoryService )
        {
            this.context = context;
            this.mapper = mapper;
           
            this.discountHistoryService = discountHistoryService;
        }

        public int CreateOrder(int BasketId, int UserAddressId, PaymentMethod paymentMethod)
        {
            var basket = context.Baskets
                         .Include(p => p.Items)
                         .ThenInclude(p => p.CatalogItem).ThenInclude(p => p.Discounts)
                         .Include(p=> p.AppliedDiscount)
                         .SingleOrDefault(p => p.Id == BasketId);
            //بدست آودن شناسه ای دی محصول های داخل سبد
            int[] Ids = basket.Items.Select(p => p.CatalogItemId).ToArray();
            // بدست آوردن محصول های داخل سبد
            var catalogItems = context.CatalogItems
                .Include(p => p.CatalogItemImages)
                .Include(p=>p.Discounts)
                .Where(p => Ids.Contains(p.Id));


            var orderItems = basket.Items.Select(basketItem =>
           {
               var catalogItem = catalogItems.First(c => c.Id == basketItem.CatalogItemId);

               var orderitem = new OrderItem(catalogItem.Id,
                   catalogItem.Name,
                  GlobalConstants.serverImageUrl +
                   (catalogItem?.CatalogItemImages?.FirstOrDefault()?.Src ?? ""),
                   catalogItem.Price, basketItem.Quantity);
               return orderitem;

           }).ToList();
            //بدست آوردن آدرس کاربر
            var userAddress = context.UserAddresses.SingleOrDefault(p => p.Id == UserAddressId);
            var address = mapper.Map<Address>(userAddress);
            //ایجاد سفارش محصول
            var order = new Order(basket.BuyerId, address, orderItems, paymentMethod,basket.AppliedDiscount);
            context.Orders.Add(order);
            //حذف سبد خردید
          //  context.Baskets.Remove(basket);
            context.SaveChanges();

            if(basket.AppliedDiscount != null)
            {
                discountHistoryService.InsertDiscountUsageHistory(basket.Id, order.Id);
            }
            return order.Id;

        }
    }
}
