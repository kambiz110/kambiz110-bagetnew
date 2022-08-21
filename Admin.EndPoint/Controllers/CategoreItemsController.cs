using Admin.EndPoint.Helper;
using Admin.EndPoint.Helper.UploadFile;
using Admin.EndPoint.ViewModels.Catalogs;
using Application.Catalogs.CatalogFeature.Command;
using Application.Catalogs.CatalogFeature.Dto;
using Application.Catalogs.CatalogItems.GetCatalogItemAdmin;
using Application.Catalogs.CatalogItems.IncreaseCatalogItems;
using Application.Catalogs.CatalogItems.RemoveImage;
using Application.Catalogs.CatalohItems.AddNewCatalogItem;
using Application.Catalogs.CatalohItems.CatalogItemServices;
using Application.Discounts;
using Application.Dtos;
using Application.Storerooms.Command;
using Application.Storerooms.Dto;
using Application.Users.Token;
using Infrastructure.ExternalApi.ImageServer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.EndPoint.Controllers
{
    [Authorize]
    public class CategoreItemsController : Controller
    {
        private readonly IAddNewCatalogItemService addNewCatalogItemService;
        private readonly IUploadFile imageUploadService;
        private readonly IDeleteImageService deleteImageService;
        private readonly IAddStoreroom addStoreroom;
        private readonly IGetAdminEditCatalogItem getAdminEditCatalogItem;
        private readonly ICatalogItemService catalogItemService;
        private readonly IRemoveFeacherService removeFeacherService;
        private readonly IGetDescountForEdit descountForEdit;
        private readonly IincreaseCattalogItem iincreaseCattalog;
        private readonly IGetUserToken getUserToken;

        public CategoreItemsController(IGetAdminEditCatalogItem getAdminEditCatalogItem
            , ICatalogItemService catalogItemService
            , IRemoveFeacherService removeFeacherService,
            IAddNewCatalogItemService addNewCatalogItemService,
            IUploadFile imageUploadService
            , IDeleteImageService deleteImageService,
            IAddStoreroom addStoreroom, IGetDescountForEdit descountForEdit,
            IincreaseCattalogItem iincreaseCattalog,
            IGetUserToken getUserToken)
        {
            this.getAdminEditCatalogItem = getAdminEditCatalogItem;
            this.catalogItemService = catalogItemService;
            this.removeFeacherService = removeFeacherService;
            this.addNewCatalogItemService = addNewCatalogItemService;
            this.imageUploadService = imageUploadService;
            this.deleteImageService = deleteImageService;
            this.addStoreroom = addStoreroom;
            this.descountForEdit = descountForEdit;
            this.iincreaseCattalog = iincreaseCattalog;
            this.getUserToken = getUserToken;
        }

        public IActionResult Index(int pageIndex = 1, int pageSize = 20, string search = "")
        {
            if (search == "clear")
            {
                HttpContext.Session.Remove("productes");
            }

            SearchInCategoreItemsDto productes = SessionHelper.GetObjectFromJson<SearchInCategoreItemsDto>(HttpContext.Session, "productes");

            var CatalogItems = catalogItemService.GetCatalogList(pageIndex, pageSize , productes);
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
            TempData["AvailableStock"] = model.AvailableStock;
            return View(model);
        }
        [HttpPost]
        public IActionResult EditCatalogItem(AddNewCatalogItemDto Data ) {
            List<IFormFile> Files = new List<IFormFile>() ;
            ModelState.Remove("Id");
            if (!ModelState.IsValid)
            {
                var allErrors = ModelState.Values.SelectMany(v => v.Errors);
                var errorList = allErrors.Select(p => p.ErrorMessage).ToList();
                return new JsonResult(new BaseDto<int>(false, errorList, 0));
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
                var result = imageUploadService.UploadFileToServersResized(Files ,1000 ,600);
                foreach (var item in result.FileNameAddress)
                {
                    images.Add(new AddNewCatalogItemImage_Dto { Src = item });
                }
            }
            if (Data.AvailableStock - (int)TempData["AvailableStock"]>0)
            {
                var userId = ClaimUtility.GetUserId(User);
                var result = addStoreroom.add(new AddStoreroomDto() { CatalogItemId = Data.Id, StockCount = Data.AvailableStock - (int)TempData["AvailableStock"], UserId = userId ,Status=2 });
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
        [HttpPost]
        public IActionResult AddCatalogItemToStoreroom(int id , int count)
        {
          var  userId = ClaimUtility.GetUserId(User);
            var result = addStoreroom.add(new AddStoreroomDto() { CatalogItemId=id,StockCount=count,UserId= userId, Status = 3 });
           var addResult= iincreaseCattalog.addStock(id, count);
            return new JsonResult(result?"موفق":"نا موفق");
        }
        public IActionResult HistorieCatalogItemToStoreroom(int id)
        {
           
            return new JsonResult(null);
        }
        public IActionResult NotAvailableItem(int id)
        {
           
            return new JsonResult(null);
        }
        public IActionResult GetProduct(int id)
        {
            var ee = catalogItemService.GetCatalogItem(id);
            return new JsonResult(ee);
        }
    }
}
