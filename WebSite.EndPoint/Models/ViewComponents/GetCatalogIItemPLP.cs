using Application.Catalogs.CatalogItems.GetCatalogIItemPLP;
using Application.HomePageService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite.EndPoint.Models.ViewComponents
{
    public class GetCatalogIItemPLP : ViewComponent
    {
        private readonly IGetCatalogIItemPLPService getCatalogIItemPLPService;

        public GetCatalogIItemPLP(IGetCatalogIItemPLPService getCatalogIItemPLPService)
        {
            this.getCatalogIItemPLPService = getCatalogIItemPLPService;
        }
        public IViewComponentResult Invoke(CatlogPLPRequestDto dto)
        {
            var model = getCatalogIItemPLPService.Execute(dto);
            var viewName = $"~/Views/Shared/Components/Product/{this.ViewComponentContext.ViewComponentDescriptor.ShortName}.cshtml";
            return View(viewName, model);
        }
    }
}
