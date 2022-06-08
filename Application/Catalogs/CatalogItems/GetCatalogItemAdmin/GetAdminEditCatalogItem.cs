using Application.Catalogs.CatalogItems.UriComposer;
using Application.Catalogs.CatalohItems.AddNewCatalogItem;
using Application.Interfaces.Contexts;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Catalogs.CatalogItems.GetCatalogItemAdmin
{
  
    public interface IGetAdminEditCatalogItem
    {
        AddNewCatalogItemDto Execute(int Id);
    } 
    public class GetAdminEditCatalogItem : IGetAdminEditCatalogItem
    {
        private readonly IDataBaseContext context;
        private readonly IMapper mapper;
        private readonly IUriComposerService uriComposerService;
        public GetAdminEditCatalogItem(IDataBaseContext context, IMapper mapper , IUriComposerService uriComposerService)
        {
            this.context = context;
            this.mapper = mapper;
           this. uriComposerService = uriComposerService;
        }

        public AddNewCatalogItemDto Execute(int Id)
        {
            var catalogitem = context.CatalogItems.AsNoTracking()
               .Include(p => p.CatalogItemFeatures)
               .Include(p => p.CatalogItemImages)
               .Include(p => p.CatalogType)
               .Include(p => p.CatalogBrand)
               .Include(p => p.Discounts)
               .SingleOrDefault(p => p.Id == Id);


            var model = mapper.Map<AddNewCatalogItemDto>(catalogitem);
            var feature = catalogitem.CatalogItemFeatures
                .Select(p => new AddNewCatalogItemFeature_dto
                {
                    Group = p.Group,
                    Key = p.Key,
                    Value = p.Value
                }).ToList();
                //.GroupBy(p => p.Group);
               
            return model;
        }
    }
}
