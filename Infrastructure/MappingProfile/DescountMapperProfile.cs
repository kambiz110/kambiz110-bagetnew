using Application.Discounts.AddNewDiscountServices;
using Application.Discounts.Dto;
using AutoMapper;
using Domain.Discounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.MappingProfile
{
   public class DescountMapperProfile : Profile
    {
        public DescountMapperProfile()
        {
            //----------------------------
            CreateMap<Discount, AddNewDiscountDto>().ReverseMap();
            CreateMap<Discount, GetDescountsForAdminViewModel>().ReverseMap();

            CreateMap<Discount, GetDescountsForEditViewModel>()
                 .ForMember(dest => dest.catalogItems, opt =>
                opt.MapFrom(src => src.CatalogItems.Select(p=> new catalogitemDtoForEditDescount { 
               Id=p.Id,   Name=p.Name, Price=p.Price  })))
                .ReverseMap();
        }
    }
}
