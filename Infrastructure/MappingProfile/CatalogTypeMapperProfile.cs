using Application.Catalogs.CatalogTypes;
using Application.Catalogs.CatalogTypes.Dto;
using Application.Catalogs.GetMenuItem;
using AutoMapper;
using Domain.Catalogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.MappingProfile
{
    public class CatalogTypeMapperProfile : Profile
    {
        public CatalogTypeMapperProfile()
        {

            CreateMap<CatalogTypeDto, CatalogTypeViewModel>().ReverseMap();

            CreateMap<CatalogType, CatalogTypeDto>().ReverseMap();
            CreateMap<CatalogType, CatalogTypeViewModel>().ReverseMap();

            CreateMap<CatalogType, CatalogTypeListDto>()
                .ForMember(dest => dest.SubTypeCount, option =>
                 option.MapFrom(src => src.SubType.Count));

            CreateMap<CatalogType, MenuItemDto>()
              .ForMember(dest => dest.Name, opt =>
               opt.MapFrom(src => src.Type))
              .ForMember(dest => dest.ParentId, opt =>
               opt.MapFrom(src => src.ParentCatalogTypeId))
              .ForMember(dest => dest.SubMenu, opt =>
              opt.MapFrom(src => src.SubType));
        }
    }
}
