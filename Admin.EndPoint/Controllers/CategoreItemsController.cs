using Application.Catalogs.CatalogFeature.Command;
using Application.Catalogs.CatalogFeature.Dto;
using Application.Catalogs.CatalogItems.GetCatalogItemAdmin;
using Application.Catalogs.CatalohItems.AddNewCatalogItem;
using Application.Catalogs.CatalohItems.CatalogItemServices;
using Application.Dtos;
using Infrastructure.ExternalApi.ImageServer;
using Microsoft.AspNetCore.Http;
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
        private readonly IAddNewCatalogItemService addNewCatalogItemService;
        private readonly IImageUploadService imageUploadService;
        private readonly IGetAdminEditCatalogItem getAdminEditCatalogItem;
        private readonly ICatalogItemService catalogItemService;
        private readonly IRemoveFeacherService removeFeacherService;

        public CategoreItemsController(IGetAdminEditCatalogItem getAdminEditCatalogItem
            , ICatalogItemService catalogItemService
            , IRemoveFeacherService removeFeacherService,
            IAddNewCatalogItemService addNewCatalogItemService,
            IImageUploadService imageUploadService)
        {
            this.getAdminEditCatalogItem = getAdminEditCatalogItem;
            this.catalogItemService = catalogItemService;
            this.removeFeacherService = removeFeacherService;
            this.addNewCatalogItemService = addNewCatalogItemService;
            this.imageUploadService = imageUploadService;
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
        [HttpPost]
        public IActionResult EditCatalogItem(AddNewCatalogItemDto Data ) {
            List<IFormFile> Files = new List<IFormFile>() ;
            ModelState.Remove("Id");
            if (!ModelState.IsValid)
            {
                var allErrors = ModelState.Values.SelectMany(v => v.Errors);
                return new JsonResult(new BaseDto<int>(false, allErrors.Select(p => p.ErrorMessage).ToList(), 0));
            }
            for (int i = 0; i < Request.Form.Files.Count; i++)
            {
                var file = Request.Form.Files[i];
                Files.Add(file);
            }
           
            List<AddNewCatalogItemImage_Dto> images = new List<AddNewCatalogItemImage_Dto>();
            if (Files.Count > 0)
            {
                //Upload 
                var result = imageUploadService.Upload(Files);
                foreach (var item in result)
                {
                    images.Add(new AddNewCatalogItemImage_Dto { Src = item });
                }
            }

            Data.Images = images;
            var resultService = addNewCatalogItemService.Execute(Data);
            return new JsonResult(resultService);
         
        }
        public IActionResult RemoveFeature(RemoveFeatureDto data)
        {
            var result = removeFeacherService.Exequte(data);
            return new JsonResult(result);
        }

    }
}
