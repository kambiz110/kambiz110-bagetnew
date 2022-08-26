

using Application.PostalProducts.Dto;
using Application.Users.Dto;
using AutoMapper;
using Domain.Postals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.MappingProfile
{
    public class PostalProductMappingProfile : Profile
    {
        public PostalProductMappingProfile()
        {
            CreateMap<AddPostalProductDto, PostProduct>().ReverseMap(); 

        }
    }
}
