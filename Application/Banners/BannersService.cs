using Application.Catalogs.CatalogItems.UriComposer;
using Application.Dtos;
using Application.Interfaces.Contexts;
using AutoMapper;
using Common;
using Domain.Banners;
using System.Collections.Generic;
using System.Linq;

namespace Application.Banners
{
    public class BannersService : IBannersService
    {
        private readonly IDataBaseContext context;
        private readonly IMapper mapper;
        private readonly IUriComposerService uriComposerService;

        public BannersService(IDataBaseContext context, IMapper mapper, IUriComposerService uriComposerService)
        {
            this.context = context;
            this.mapper = mapper;
            this.uriComposerService = uriComposerService;
        }

        public void AddBanner(BannerDto banner)
        {
            var rr = mapper.Map<Banner>(banner);
            context.Banners.Add(rr);
            context.SaveChanges();
        }

        public BaseDto<BannerDto> Edit(BannerDto dto)
        {
            var model = context.Banners.SingleOrDefault(p => p.Id == dto.Id);
            mapper.Map(dto, model);
            context.SaveChanges();
            return new BaseDto<BannerDto>
              (
               true,
                new List<string> { $"بنر {model.Name} با موفقیت ویرایش شد" },

                mapper.Map<BannerDto>(model)
              );
        }

        public BaseDto<BannerDto> FindById(int Id)
        {
            var data = context.Banners.Find(Id);
            var result = mapper.Map<BannerDto>(data);
            result.ShowImage = uriComposerService
                    .ComposeImageUri(result.Image);
            return new BaseDto<BannerDto>(
                true,
                null,
                result
                );
        }

      

        public PaginatedItemsDto<BannerDto> GetList(int page, int pageSize)
        {
            int totalCount = 0;
            var model = context.Banners
                .PagedResult(page, pageSize, out totalCount);
            var result = mapper.ProjectTo<BannerDto>(model).ToList();
            for (int i = 0; i < result.Count; i++)
            {
                result.ElementAt(i).Image= uriComposerService
                    .ComposeImageUri(result.ElementAt(i).Image);
            }
            return new PaginatedItemsDto<BannerDto>(page, pageSize, totalCount, result);
        }

        public BaseDto Remove(int Id)
        {
            var banner = context.Banners.Find(Id);
            context.Banners.Remove(banner);
            context.SaveChanges();
            return new BaseDto
            (
             true,
             new List<string> { $"بنر با موفقیت حذف شد" }
             );
        }




        public List<BannerDto> GetBanners()
        {
            var banners = context.Banners
                .Select(p => new BannerDto
                {
                    Image = p.Image,
                    IsActive = p.IsActive,
                    UniqKey = p.UniqKey,
                    CategoriType = p.CategoriType,
                    Name = p.Link,
                    Position = p.Position,
                    Priority = p.Priority,
                }).ToList();
            return banners;
        }
    }
}
