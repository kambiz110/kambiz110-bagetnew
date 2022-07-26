using Application.Banners;
using Application.Catalogs.CatalogTypes.Query;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite.EndPoint.Models.ViewComponents
{
    public class CategoriesMenu : ViewComponent
    {
        private readonly IRenderCategoriesMenuService menuService;

        public CategoriesMenu(IRenderCategoriesMenuService  menuService)
        {
            this.menuService = menuService;
        }

        public IViewComponentResult Invoke()
        {
            var model = menuService.Exequt();
            var viewName = $"~/Views/Shared/{this.ViewComponentContext.ViewComponentDescriptor.ShortName}.cshtml";
            return View(viewName, model);
        }
    }
}
