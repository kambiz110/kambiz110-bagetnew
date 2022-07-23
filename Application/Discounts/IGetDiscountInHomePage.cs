using Application.Catalogs.CatalogItems.UriComposer;
using Application.Discounts.Dto;
using Application.Dtos;
using Application.Interfaces.Contexts;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Discounts
{
    /// <summary>
    /// نمایش محصول های داراری تخفیف بر اساس اهمیت صفحه نخست
    /// </summary>
    public interface IGetDiscountInHomePage
    {
        BaseDto<GetDiscountInHomePageViewModel> Executed(int Importance, int count);
    }
    public class GetDiscountInHomePage : IGetDiscountInHomePage
    {
        private readonly IDataBaseContext context;
        private readonly IMapper mapper;
        private readonly IUriComposerService uriComposerService;

        public GetDiscountInHomePage(IDataBaseContext context, IMapper mapper, IUriComposerService uriComposerService)
        {
            this.context = context;
            this.mapper = mapper;
            this.uriComposerService = uriComposerService;
        }

        public BaseDto<GetDiscountInHomePageViewModel> Executed(int Importance, int count)
        {
            var data = context.Discount.AsNoTracking()
                .Where(p => p.Importance == Importance && p.UsePercentage==true)
                 .OrderByDescending(p => p.DiscountPercentage)
                .Include(p => p.CatalogItems).ThenInclude(p => p.CatalogItemImages)
                .Include(p => p.CatalogItems).ThenInclude(p => p.CatologCar)
                .Include(p => p.CatalogItems).ThenInclude(p => p.CatalogBrand)
            .AsQueryable();
            var result = mapper.ProjectTo<GetDiscountInHomePageViewModel>(data).FirstOrDefault();
            if (result != null)
            {
                for (int j = 0; j < result.catalogItems.Count; j++)
                {
                    result.catalogItems.ElementAt(j).Src = uriComposerService.ComposeImageUri(result.catalogItems.ElementAt(j).Src);
                }


                return new BaseDto<GetDiscountInHomePageViewModel>(
                 true,
                 null,
                 result
                 );
            }
            return new BaseDto<GetDiscountInHomePageViewModel>(
              false,
              null,
              null
              );
        }
    }
}
