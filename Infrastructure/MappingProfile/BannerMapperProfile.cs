using Application.Banners;
using AutoMapper;
using Domain.Banners;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.MappingProfile
{
   public class BannerMapperProfile : Profile
    {
        public BannerMapperProfile()
        {
            CreateMap<Banner, BannerDto>().ReverseMap();
        }
    }
}
