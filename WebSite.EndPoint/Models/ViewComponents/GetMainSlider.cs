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
        private readonly IGetBanerHomePage banners;

        public GetMainSlider(IGetBanerHomePage banners)
        {
            this.banners = banners;
        }

        public IViewComponentResult Invoke(int position=0, int count=4)
        {
            var model = banners.Executed(position, count);
            var viewName = $"~/Views/Shared/Components/Product/{this.ViewComponentContext.ViewComponentDescriptor.ShortName}.cshtml";
            return View(viewName, model.Data);
        }
    }
}
