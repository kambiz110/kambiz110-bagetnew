using Admin.EndPoint.Helper;
using Admin.EndPoint.ViewModels.Catalogs;
using Application.Catalogs.CatalogFeature.Command;
using Application.Catalogs.CatalogFeature.Dto;
using Application.Catalogs.CatalogItems.GetCatalogItemAdmin;
using Application.Catalogs.CatalogItems.RemoveImage;
using Application.Catalogs.CatalohItems.AddNewCatalogItem;
using Application.Catalogs.CatalohItems.CatalogItemServices;
using Application.Discounts;
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
        private readonly IDeleteImageService deleteImageService;
        private readonly IGetAdminEditCatalogItem getAdminEditCatalogItem;
        private readonly ICatalogItemService catalogItemService;
        private readonly IRemoveFeacherService removeFeacherService;
        private readonly IGetDescountForEdit descountForEdit;
        public CategoreItemsController(IGetAdminEditCatalogItem getAdminEditCatalogItem
            , ICatalogItemService catalogItemService
            , IRemoveFeacherService removeFeacherService,
            IAddNewCatalogItemService addNewCatalogItemService,
            IImageUploadService imageUploadService
            , IDeleteImageService deleteImageService, IGetDescountForEdit descountForEdit )
        {
            this.getAdminEditCatalogItem = getAdminEditCatalogItem;
            this.catalogItemService = catalogItemService;
            this.removeFeacherService = removeFeacherService;
            this.addNewCatalogItemService = addNewCatalogItemService;
            this.imageUploadService = imageUploadService;
            this.deleteImageService = deleteImageService;
            this.descountForEdit = descountForEdit;
        }

        public IActionResult Index(int page = 1, int pageSize = 100, string search = "")
        {
            if (search == "clear")
            {
                HttpContext.Session.Remove("productes");
            }

            SearchInCategoreItemsDto productes = SessionHelper.GetObjectFromJson<SearchInCategoreItemsDto>(HttpContext.Session, "productes");

            var CatalogItems = catalogItemService.GetCatalogList(page, pageSize , productes);
            ViewData["Cars"] = new SelectList(catalogItemService.GetCares(), "Id", "Name");
            ViewData["Companes"] = new SelectList(catalogItemService.GetCompanes(), "Id", "Name");
            ViewData["Categories"] = new SelectList(catalogItemService.GetCatalogType(), "Id", "Type");
            ViewData["Brands"] = new SelectList(catalogItemService.GetBrand(), "Id", "Brand");
            return View(CatalogItems);
        }
        [HttpPost]
        public IActionResult Index(SearchInCategoreItemsDto dto)
        {
            var  CatalogItems = catalogItemService.GetCatalogList(1, 100 ,dto);
            ViewData["Cars"] = new SelectList(catalogItemService.GetCares(), "Id", "Name");
            ViewData["Companes"] = new SelectList(catalogItemService.GetCompanes(), "Id", "Name");
            ViewData["Categories"] = new SelectList(catalogItemService.GetCatalogType(), "Id", "Type");
            ViewData["Brands"] = new SelectList(catalogItemService.GetBrand(), "Id", "Brand");
          
            SessionHelper.SetObjectAsJson(HttpContext.Session, "productes", dto);
            return View(CatalogItems);
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
        [HttpPost]
        public IActionResult RemoveImageProdact(DeleteImageDto data)
        {

            var result = deleteImageService.delete(data.itemId, data.src);
            return new JsonResult(result);
        }
    
    }
}
