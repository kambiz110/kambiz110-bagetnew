using Application.Catalogs.CatalogItems.UriComposer;
using Application.Discounts.Dto;
using Application.Dtos;
using Application.Interfaces.Contexts;
using AutoMapper;
using Common.Useful;
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
        BaseDto<GetDiscountInHomePageViewModel> Vijeh();
        BaseDto<GetDiscountInHomePageViewModel> HomePage();
    }
    public class GetDiscountInHomePage : IGetDiscountInHomePage
    {
        private readonly IDataBaseContext context;
        private readonly IMapper mapper;
     

        public GetDiscountInHomePage(IDataBaseContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
           
        }

        public BaseDto<GetDiscountInHomePageViewModel> Vijeh()
        {
            var data = context.Discount.AsNoTracking()
                .Where(p => p.Importance == 3 && p.UsePercentage==true)
                 .OrderByDescending(p => p.DiscountPercentage)
                 .Include(p => p.CatalogItems.Where(p=>p.IsActive==true).Take(5))
                .Include(p => p.CatalogItems).ThenInclude(p => p.CatalogItemImages)
                .Include(p => p.CatalogItems).ThenInclude(p => p.CatologCar)
                .Include(p => p.CatalogItems).ThenInclude(p => p.CatalogBrand)
            .AsQueryable();
            var result = mapper.ProjectTo<GetDiscountInHomePageViewModel>(data).FirstOrDefault();
            if (result != null)
            {
                for (int j = 0; j < result.catalogItems.Count; j++)
                {
                    result.catalogItems.ElementAt(j).Src = GlobalConstants.serverImageUrl + (result.catalogItems.ElementAt(j).Src);
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
        public BaseDto<GetDiscountInHomePageViewModel> HomePage()
        {
            var data = context.Discount.AsNoTracking()
                .Where(p => p.Importance == 2 && p.UsePercentage==true)
                 .OrderByDescending(p => p.DiscountPercentage)
                .Include(p => p.CatalogItems.Where(p => p.IsActive == true)).ThenInclude(p => p.CatalogItemImages)
                .Include(p => p.CatalogItems.Where(p => p.IsActive == true)).ThenInclude(p => p.CatologCar)
                .Include(p => p.CatalogItems.Where(p => p.IsActive == true)).ThenInclude(p => p.CatalogBrand)
            .AsQueryable();
            var result = mapper.ProjectTo<GetDiscountInHomePageViewModel>(data).FirstOrDefault();
            if (result!=null)
            {
          var catlogcount = result.catalogItems.Count();
            var takke = 12;
            if (catlogcount>4 && catlogcount<8)
            {
                takke = 4;
            }
            if (catlogcount>8 && catlogcount<12)
            {
                takke = 8;
            }
          
            result.catalogItems = result.catalogItems.Take(takke).ToList();
          
                for (int j = 0; j < result.catalogItems.Count; j++)
                {
                    result.catalogItems.ElementAt(j).Src = GlobalConstants.serverImageUrl + (result.catalogItems.ElementAt(j).Src);
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
