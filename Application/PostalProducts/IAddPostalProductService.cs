using Application.Interfaces.Contexts;
using Application.PostalProducts.Dto;
using AutoMapper;
using Domain.Postals;
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
        public async Task addPostal(AddPostalProductDto dto)
        {
            if (dto.Id>0)
            {
                var postal = context.PostProducts.FirstOrDefault(p=>p.Id==dto.Id);
                if (postal!=null)
                {
                    _mapper.Map(dto, postal);
                    context.PostProducts.Update(postal);
                    var order = context.Orders.FirstOrDefault(p => p.Id == dto.OrderId);
                    order.OrderPostOfficalDelivered();
                    await   context.SaveChangesAsync();
                }
            }
            else
            {
              var postamodel=  _mapper.Map<PostProduct>(dto);
                context.PostProducts.Add(postamodel);
                var order = context.Orders.FirstOrDefault(p => p.Id == dto.OrderId);
                order.OrderPostOfficalDelivered();
                await context.SaveChangesAsync();

            }
        }
    }
}
