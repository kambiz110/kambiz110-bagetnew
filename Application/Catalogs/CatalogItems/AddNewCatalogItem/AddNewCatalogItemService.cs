using Application.Dtos;
using Application.Interfaces.Contexts;
using AutoMapper;
using Common.Useful;
using Domain.Catalogs;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Application.Catalogs.CatalohItems.AddNewCatalogItem
{
    public class AddNewCatalogItemService : IAddNewCatalogItemService
    {
        private readonly IDataBaseContext context;
        private readonly IMapper mapper;
        public AddNewCatalogItemService(IDataBaseContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        public BaseDto<int> Execute(AddNewCatalogItemDto request)
        {
            request.Slug = !string.IsNullOrEmpty(request.Slug) ? request.Slug.GenerateSeoFriendlyUrlSlug() : request.Name.GenerateSeoFriendlyUrlSlug();
            if (request.Id > 0)
            {
                var Catalogitem = context.CatalogItems.AsNoTracking().Where(p => p.Id == request.Id).FirstOrDefault();
                if (Catalogitem != null)
                {

                    var catalogItem2 = new CatalogItem(request.Id, request.Price, request.Name, request.Description ?? "", request.Slug, request.CatalogCompanyId, request.CatalogTypeId, request.CatalogBrandId, request.CatologCarId,
                        request.AvailableStock, request.RestockThreshold, request.MaxStockThreshold
                        ,request.Importance,request.Width,request.Height , request.Length, request.Weight);



                    // var catalogItem2 = mapper.Map<CatalogItem>(request);
                    context.CatalogItems.Update(catalogItem2);
                    context.SaveChanges();

                    if (request.Features != null && request.Features.Count() > 0)
                    {
                        var FeaturesToDb = mapper.Map<List<CatalogItemFeature>>(request.Features);
                        for (int i = 0; i < FeaturesToDb.Count(); i++)
                        {
                            FeaturesToDb.ElementAt(i).CatalogItemId = catalogItem2.Id;
                            context.CatalogItemFeatures.Add(FeaturesToDb.ElementAt(i));
                        }
                       
                    }
                    foreach (var item in request.Images)
                    {
                        context.CatalogItemImage.Add(new CatalogItemImage { Src = item.Src, CatalogItemId = catalogItem2.Id });
                    }
                    context.SaveChanges();
                    return new BaseDto<int>(true, new List<string> { "با موفقیت ثبت شد" }, catalogItem2.Id);
                }
                return new BaseDto<int>(false, new List<string> { "ناموفق" }, 0);
            }
            else
            {

                var catalogItem2 = new CatalogItem(request.Price, request.Name, request.Description ?? "", request.Slug, request.CatalogCompanyId, request.CatalogTypeId, request.CatalogBrandId, request.CatologCarId,
                    request.AvailableStock, request.RestockThreshold, request.MaxStockThreshold
                    , request.Importance, request.Width, request.Height, request.Length ,request.Weight);



                // var catalogItem2 = mapper.Map<CatalogItem>(request);
                context.CatalogItems.Add(catalogItem2);
                context.SaveChanges();
                request.Id = catalogItem2.Id;
                if (request.Features != null && request.Features.Count() > 0)
                {
                    var FeaturesToDb = mapper.Map<List<CatalogItemFeature>>(request.Features);
                    for (int i = 0; i < FeaturesToDb.Count(); i++)
                    {
                        FeaturesToDb.ElementAt(i).CatalogItemId = catalogItem2.Id;
                        context.CatalogItemFeatures.Add(FeaturesToDb.ElementAt(i));
                    }



                }
                foreach (var item in request.Images)
                {
                    context.CatalogItemImage.Add(new CatalogItemImage { Src = item.Src, CatalogItemId = catalogItem2.Id });
                }
                context.SaveChanges();
                return new BaseDto<int>(true, new List<string> { "با موفقیت ثبت شد" }, catalogItem2.Id);
            }

        }
    }
}
