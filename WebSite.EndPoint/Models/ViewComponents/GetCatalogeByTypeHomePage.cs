using Application.Catalogs.CatalogTypes;
using Application.Catalogs.CatalogTypes.Query;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite.EndPoint.Models.ViewComponents
{
    public class GetCatalogeByTypeHomePage : ViewComponent
    {
        private readonly IGetCatalogeTypeHomePage catalogeTypeHomePage;

        public GetCatalogeByTypeHomePage(IGetCatalogeTypeHomePage catalogeTypeHomePage)
        {
            this.catalogeTypeHomePage = catalogeTypeHomePage;
        }
        public IViewComponentResult Invoke(int? parentId, int sortIndex = 3, int count = 4)
        {
            var model = catalogeTypeHomePage.Execut(parentId, sortIndex, count);
            var viewName = $"~/Views/Shared/Components/Product/{this.ViewComponentContext.ViewComponentDescriptor.ShortName}.cshtml";
            return View(viewName, model);
        }
    }
}
