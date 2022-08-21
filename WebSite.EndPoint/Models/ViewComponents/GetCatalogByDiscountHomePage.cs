using Application.Catalogs.CatalogItems.Dto;
using Application.Discounts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite.EndPoint.Models.ViewComponents
{
    public class GetCatalogByDiscountHomePage : ViewComponent
    {
        private readonly IGetDiscountInHomePage getDiscountInHomePage;

        public GetCatalogByDiscountHomePage(IGetDiscountInHomePage getDiscountInHome)
        {
            this.getDiscountInHomePage = getDiscountInHome;
        }
        public IViewComponentResult Invoke()
        {
            var model =new GetHomePageTwoDiscountCatalogItemsViewModel();
            var Vijeh = getDiscountInHomePage.Vijeh().Data;
            var HomePage = getDiscountInHomePage.HomePage().Data;
            model.Vijeh = Vijeh;
            model.HomePage = HomePage;
            var viewName = $"~/Views/Shared/Components/Product/{this.ViewComponentContext.ViewComponentDescriptor.ShortName}.cshtml";
            return View(viewName, model);
        }
    }
}
