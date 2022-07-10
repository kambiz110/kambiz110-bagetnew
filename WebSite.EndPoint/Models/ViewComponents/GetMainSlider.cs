using Application.Banners;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite.EndPoint.Models.ViewComponents
{
    public class GetMainSlider : ViewComponent
    {
        private readonly IBannersService banners;

        public GetMainSlider(IBannersService banners)
        {
            this.banners = banners;
        }

        public IViewComponentResult Invoke(int page=1, int pageSize=4)
        {
            var model = banners.GetList(page , pageSize);
            var viewName = $"~/Views/Shared/Components/Product/{this.ViewComponentContext.ViewComponentDescriptor.ShortName}.cshtml";
            return View(viewName, model.Data);
        }
    }
}
