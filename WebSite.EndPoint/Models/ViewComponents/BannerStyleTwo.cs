using Application.Banners;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite.EndPoint.Models.ViewComponents
{
    public class BannerStyleTwo : ViewComponent
    {
        private readonly IGetBanerHomePage banners;

        public BannerStyleTwo(IGetBanerHomePage banners)
        {
            this.banners = banners;
        }

        public IViewComponentResult Invoke(int position = 2, int count = 2)
        {
            var model = banners.Executed(position, count);
            var viewName = $"~/Views/Shared/Components/Banner/{this.ViewComponentContext.ViewComponentDescriptor.ShortName}.cshtml";
            return View(viewName, model.Data);
        }
    }
}
