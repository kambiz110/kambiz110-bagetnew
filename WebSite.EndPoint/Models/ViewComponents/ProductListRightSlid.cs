using Application.ProductListPageService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite.EndPoint.Models.ViewComponents
{
    public class ProductListRightSlid : ViewComponent
    {
        private readonly IRightSildMultiEntityFilter multiEntityFilter;

        public ProductListRightSlid(IRightSildMultiEntityFilter multiEntityFilter)
        {
            this.multiEntityFilter = multiEntityFilter;
        }
        public IViewComponentResult Invoke()
        {
            var data = multiEntityFilter.Exequted();
            var viewName = $"~/Views/Shared/Components/Product/{this.ViewComponentContext.ViewComponentDescriptor.ShortName}.cshtml";
            return View(viewName: viewName, model: data);
        }
    }
}
