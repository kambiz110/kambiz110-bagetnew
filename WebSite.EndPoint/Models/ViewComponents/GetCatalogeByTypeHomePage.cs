using Application.Catalogs.CatalogTypes;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite.EndPoint.Models.ViewComponents
{
    public class GetCatalogeByTypeHomePage : ViewComponent
    {
        private readonly IMenuCatolgType menuCatolgType;

        public GetCatalogeByTypeHomePage(IMenuCatolgType menuCatolgType)
        {
            this.menuCatolgType = menuCatolgType;
        }
        public IViewComponentResult Invoke(int sortIndex, int count)
        {
            var model = menuCatolgType.ListCatalogTypeBySortIndex(sortIndex, count);
            var viewName = $"~/Views/Shared/Components/Product/{this.ViewComponentContext.ViewComponentDescriptor.ShortName}.cshtml";
            return View(viewName, model.Data);
        }
    }
}
