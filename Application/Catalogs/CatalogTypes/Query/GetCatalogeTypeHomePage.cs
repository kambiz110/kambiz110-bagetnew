using Application.Catalogs.CatalogItems.GetCatalogIItemPLP;
using Application.Catalogs.CatalogItems.UriComposer;
using Application.Catalogs.CatalogTypes.Dto;
using Application.Interfaces.Contexts;
using AutoMapper;
using Common.Useful;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Catalogs.CatalogTypes.Query
{
    /// <summary>
    /// نمایش محصول ها بر اسا دسته بندی در صفحه نخست(سه دسته بندی مهم)
    /// </summary>
   public interface IGetCatalogeTypeHomePage
    {
        GetCatalogeItemByTypeHomePageDto Execut(int?parentId,int sortIndex= 0,int count= 9);
    }
    public class GetCatalogeTypeHomePage : IGetCatalogeTypeHomePage
    {
        private readonly IDataBaseContext context;
      

        public GetCatalogeTypeHomePage(IDataBaseContext context
           )
        {
            this.context = context;

        
        }
        public GetCatalogeItemByTypeHomePageDto Execut(int? parentId, int sortIndex = 0, int count = 9)
        {
            var model = context.CatalogTypes
 .Where(p => p.SortIndex == sortIndex && p.ParentCatalogTypeId== parentId)
 .OrderByDescending(p => p.Id).Take(count)
 .Include(p => p.CatalogTypeImage)
 .Include(p=>p.CatalogItems.Where(p=>p.Importance>1).OrderByDescending(p=>p.Importance).Take(15)).ThenInclude(p=>p.CatalogItemImages)
 .Include(p => p.CatalogItems.Where(p => p.Importance > 1).OrderByDescending(p => p.Importance).Take(15)).ThenInclude(p => p.Discounts)
 .Include(p => p.CatalogItems.Where(p => p.Importance > 1).OrderByDescending(p => p.Importance).Take(15)).ThenInclude(p => p.CatologCar)
 .Include(p => p.CatalogItems.Where(p => p.Importance > 1).OrderByDescending(p => p.Importance).Take(15)).ThenInclude(p => p.CatalogBrand)
  .ToList();
            List<childCatalogeItemsByType> _itemsByTypes = new List<childCatalogeItemsByType>();
            foreach (var item in model)
            {
                if (item.CatalogItems.Count>0)
                {
   var catItem = new childCatalogeItemsByType();
                catItem.Name = item.Type;
                catItem.catalogs = item.CatalogItems.Select(o => new CatalogItemShortPLP
                {
                    Id = o.Id,
                    Name = o.Name,
                    Price = o.Price,
                    OldPrice = o.OldPrice,
                    Description = o.Description,
                    Slug = o.Slug,
                    DiscountPercentage = o.Discounts.Count > 0 ? o.Discounts.OrderByDescending(o => o.DiscountPercentage).FirstOrDefault().DiscountPercentage : 0,
                    Rate = 4,
                    Images = o.CatalogItemImages.Select(o => GlobalConstants.serverImageUrl + o.Src).ToList(),
                    AvailableStock = o.AvailableStock,
                    BrandName=o.CatalogBrand.Brand,
                    CarName=o.CatologCar.Name

                }).ToList();
                _itemsByTypes.Add(catItem);
                }
             
            }
//   var result =   model.Select(p => new childCatalogeItemsByType {
//      Name=p.Type,
//      catalogs=p.CatalogItems.Select(o=>new CatalogPLPDto {
//      Id = o.Id,
//      Name = o.Name,
//      Price = o.Price,
//      OldPrice = o.OldPrice,
//      Description = o.Description,
//      Slug = o.Slug,
//      DiscountPercentage = o.Discounts.Count > 0 ? o.Discounts.OrderByDescending(o => o.DiscountPercentage).FirstOrDefault().DiscountPercentage : 0,
//      Rate = 4,
//      Images = o.CatalogItemImages.Select(o => GlobalConstants.serverImageUrl + o.Src).ToList(),
//      AvailableStock = o.AvailableStock,

//  }).ToList()
// }
//).ToList();




            return new GetCatalogeItemByTypeHomePageDto { itemsByTypes = _itemsByTypes };
        }
    }
}
