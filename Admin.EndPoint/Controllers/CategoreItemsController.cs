using Application.Catalogs.CatalogFeature.Dto;
using Application.Catalogs.CatalogItems.GetCatalogItemAdmin;
using Application.Catalogs.CatalohItems.CatalogItemServices;
using Application.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.EndPoint.Controllers
{
    public class CategoreItemsController : Controller
    {
        private readonly IGetAdminEditCatalogItem getAdminEditCatalogItem;
        private readonly ICatalogItemService catalogItemService;

        public CategoreItemsController(IGetAdminEditCatalogItem getAdminEditCatalogItem
            ,ICatalogItemService catalogItemService)
        {
            this.getAdminEditCatalogItem = getAdminEditCatalogItem;
            this.catalogItemService = catalogItemService;
        }
       


        public IActionResult EditCatalogItem(int id)
        {

            ViewData["Cars"] = new SelectList(catalogItemService.GetCares(), "Id", "Name");
            ViewData["Companes"] = new SelectList(catalogItemService.GetCompanes(), "Id", "Name");
            ViewData["Categories"] = new SelectList(catalogItemService.GetCatalogType(), "Id", "Type");
            ViewData["Brands"] = new SelectList(catalogItemService.GetBrand(), "Id", "Brand");
            var model = getAdminEditCatalogItem.Execute(id);
            return View(model);
        }
        public IActionResult RemoveFeature(RemoveFeatureDto data)
        {

            return new JsonResult(new BaseDto(true,
               new List<string> { $"ثبت موفق" }));
        }

    }
}
