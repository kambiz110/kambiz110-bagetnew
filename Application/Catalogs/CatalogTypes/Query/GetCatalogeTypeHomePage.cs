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
   public interface IGetCatalogeTypeHomePage
    {
        GetCatalogeItemByTypeHomePageDto Execut(int?parentId,int sortIndex= 0,int count= 9);
    }
    public class GetCatalogeTypeHomePage : IGetCatalogeTypeHomePage
    {
        private readonly IDataBaseContext context;
        private readonly IMapper mapper;
        private readonly IUriComposerService uriComposerService;

        public GetCatalogeTypeHomePage(IDataBaseContext context, IMapper mapper
            , IUriComposerService uriComposerService)
        {
            this.context = context;
            this.mapper = mapper;
            this.uriComposerService = uriComposerService;
        }
        public GetCatalogeItemByTypeHomePageDto Execut(int? parentId, int sortIndex = 0, int count = 9)
        {
            var model = context.CatalogTypes
 .Where(p => p.SortIndex == sortIndex)
 .OrderByDescending(p => p.SortIndex == sortIndex && p.ParentCatalogTypeId == parentId).Take(count)
 .Include(p => p.CatalogTypeImage)
 .Include(p=>p.CatalogItems).ThenInclude(p=>p.CatalogItemImages)
  
 .Select(p => new childCatalogeItemsByType {
 Name=p.Type,
  catalogs=p.CatalogItems.Select(o=>new CatalogPLPDto {
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

  }).ToList()
 }
).ToList();
 
 


            throw new NotImplementedException();
        }
    }
}
