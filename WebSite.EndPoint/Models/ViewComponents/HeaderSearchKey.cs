using Application.Catalogs.CatalogTypes.Query;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite.EndPoint.Models.ViewComponents
{
    public class HeaderSearchKey : ViewComponent
    {
        private readonly IGetCategoreTypeHeaderSearchKey getCategoreType;

        public HeaderSearchKey(IGetCategoreTypeHeaderSearchKey getCategoreType)
        {
            this.getCategoreType = getCategoreType;
        }
        public IViewComponentResult Invoke(int sortIndex, int count, int? parentId)
        {
            var model = getCategoreType.ListCatalogTypeBySortIndex(sortIndex, count ,parentId);
            var viewName = $"~/Views/Shared/Components/Product/{this.ViewComponentContext.ViewComponentDescriptor.ShortName}.cshtml";
            return View(viewName, model.Data);
        }
    }
}
