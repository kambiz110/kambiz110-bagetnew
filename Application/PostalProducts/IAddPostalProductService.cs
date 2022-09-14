using Application.Interfaces.Contexts;
using Application.PostalProducts.Dto;
using AutoMapper;
using Domain.Order;
using Domain.Postals;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.PostalProducts
{
  public  interface IAddPostalProductService
    {
        Task addPostal(AddPostalProductDto dto);
        void ReturnedPostal(AddReturnedPostalProductDto dto);
        void ReturnedPostalToShop(int ReturnedId);
    }
    public class AddPostalProductService : IAddPostalProductService
    {
        private readonly IDataBaseContext context;
        private readonly IMapper _mapper;
        public AddPostalProductService(IDataBaseContext context, IMapper mapper)
        {
            this.context = context;
            _mapper = mapper;
        }
        public async Task addPostal(AddPostalProductDto dto )
        {
        
              var postamodel=  _mapper.Map<PostProduct>(dto);
                context.PostProducts.Add(postamodel);
                var order = context.Orders.FirstOrDefault(p => p.Id == dto.OrderId);
                order.OrderPostOfficalDelivered();
                await context.SaveChangesAsync();

           
        }

        public void ReturnedPostal(AddReturnedPostalProductDto dto)
        {
            var postamodel = _mapper.Map<ReturnedProduct>(dto);
            context.ReturnedProducts.Add(postamodel);
            var returned = context.Returneds.Include(p=>p.ReturneOrderItems).FirstOrDefault(p => p.Id == dto.ReturnedId);
            returned.ReturnedStatus=Domain.Order.ReturnedStatus.PostOfficalDelivered;
            for (int i = 0; i < returned.ReturneOrderItems.Count; i++)
            {
                returned.ReturneOrderItems.ElementAt(i).ItemStatus = ReturneOrderItemStatus.PostGivedOrderItem;
            }
             context.SaveChanges();
        }

        public void ReturnedPostalToShop(int ReturnedId)
        {
            var returned = context.Returneds.FirstOrDefault(p => p.Id == ReturnedId);
            returned.ReturnedStatus = Domain.Order.ReturnedStatus.Returned;
            context.SaveChangesAsync();
        }
    }
}
