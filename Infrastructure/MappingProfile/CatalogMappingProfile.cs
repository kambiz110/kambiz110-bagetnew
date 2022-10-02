using Application.Banners;
using Application.Catalogs.CatalogCars.Dto;
using Application.Catalogs.CatalogCompany.Dto;
using Application.Catalogs.CatalogItems.GetCatalogIItemPLP;
using Application.Catalogs.CatalogTypeImages;

using Application.Catalogs.CatalohItems.AddNewCatalogItem;
using Application.Catalogs.CatalohItems.CatalogItemServices;

using AutoMapper;

using Domain.Catalogs;


namespace Infrastructure.MappingProfile
{
    public class CatalogMappingProfile : Profile
    {
        public CatalogMappingProfile()
        {




            //----------------------
            // پروفایل مپ افزودن مورد جدید
            CreateMap<CatalogItemFeature, AddNewCatalogItemFeature_dto>().ReverseMap();
            CreateMap<CatalogItemImage, AddNewCatalogItemImage_Dto>().ReverseMap();

            CreateMap<CatalogItem, AddNewCatalogItemDto>()
                .ForMember(dest => dest.Features, opt =>
                opt.MapFrom(src => src.CatalogItemFeatures))
                 .ForMember(dest => dest.Images, opt =>
                 opt.MapFrom(src => src.CatalogItemImages));

            CreateMap<AddNewCatalogItemDto, CatalogItem>();

            CreateMap<ShortCatalogRSSDto, CatalogItem>().ReverseMap(); 

            CreateMap<CatalogItem, CatalogItemListItemDto>()
                 .ForMember(dest => dest.Brand, opt =>
                opt.MapFrom(src => src.CatalogBrand.Brand))
                  .ForMember(dest => dest.Type, opt =>
                opt.MapFrom(src => src.CatalogType.Type));
            //-------------------
            CreateMap<CatalogBrand, CatalogBrandDto>().ReverseMap();
    

            //-----------------------
            CreateMap<CatalogCompany, CompanyDto>().ReverseMap();
            CreateMap<CatalogCompany, CompanyListDto>().ReverseMap();

            //--------------------------
            CreateMap<CatalogBrand, CatalogBrandDto>().ReverseMap();

 
  
            //----------------------------
            CreateMap<CatologCar, CarDto>().ReverseMap();
            CreateMap<CatologCar, CarListDto>().ReverseMap();
            //--------------------------------
            CreateMap<CatalogTypeImageDto, CatalogTypeImage>().ReverseMap();
        
        }
    }
}
