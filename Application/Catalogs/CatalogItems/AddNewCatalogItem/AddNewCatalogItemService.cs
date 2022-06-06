using Application.Dtos;
using Application.Interfaces.Contexts;
using AutoMapper;
using Common.Useful;
using Domain.Catalogs;
using System.Collections.Generic;

namespace Application.Catalogs.CatalohItems.AddNewCatalogItem
{
    public class AddNewCatalogItemService : IAddNewCatalogItemService
    {
        private readonly IDataBaseContext context;
        private readonly IMapper mapper;
        public AddNewCatalogItemService(IDataBaseContext context,IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        public BaseDto<int> Execute(AddNewCatalogItemDto request)
        {
            request.Slug = !string.IsNullOrEmpty(request.Slug) ? request.Slug.GenerateSeoFriendlyUrlSlug() : request.Name.GenerateSeoFriendlyUrlSlug();
            var catalogItem = mapper.Map<CatalogItem>(request);
            context.CatalogItems.Add(catalogItem);
            context.SaveChanges();
            return new BaseDto<int>(true, new List<string> { "با موفقیت ثبت شد" }, catalogItem.Id);
        }
    }
}
