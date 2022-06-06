using Application.Dtos;
using Application.Interfaces.Contexts;
using AutoMapper;
using Common.Useful;
using Domain.Catalogs;
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
                var Catalogitem = context.CatalogItems.Where(p => p.Id == request.Id).FirstOrDefault();
                if (Catalogitem != null)
                {
                    mapper.Map(Catalogitem, request);
                    context.SaveChanges();
                    return new BaseDto<int>(true, new List<string> { "با موفقیت ثبت شد" }, Catalogitem.Id);
                }
                return new BaseDto<int>(false, new List<string> { "ناموفق" }, 0);
            }
            else
            {

                var catalogItem2 = new CatalogItem(request.Price, request.Name, request.Description ?? "", request.Slug, request.CatalogCompanyId, request.CatalogTypeId, request.CatalogBrandId,
                    request.AvailableStock, request.RestockThreshold, request.MaxStockThreshold);
     


               // var catalogItem2 = mapper.Map<CatalogItem>(request);
                context.CatalogItems.Add(catalogItem2);
                context.SaveChanges();
                request.Id = catalogItem2.Id;
                var FeaturesToDb = mapper.Map<List<CatalogItemFeature>>(request.Features);
                for (int i = 0; i < FeaturesToDb.Count(); i++)
                {
                    FeaturesToDb.ElementAt(i).CatlogItemId = catalogItem2.Id;
                   context.CatalogItemFeatures.Add(FeaturesToDb.ElementAt(i));
                }
                context.SaveChanges();
                return new BaseDto<int>(true, new List<string> { "با موفقیت ثبت شد" }, catalogItem2.Id);
            }

        }
    }
}
