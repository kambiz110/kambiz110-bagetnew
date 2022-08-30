using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.EndPoint.Helper;
using Admin.EndPoint.Helper.UploadFile;
using Application.Catalogs.CatalohItems.AddNewCatalogItem;
using Application.Catalogs.CatalohItems.CatalogItemServices;
using Application.Dtos;
using Application.Storerooms.Command;
using Application.Storerooms.Dto;
using Application.Users.Token;
using Infrastructure.ExternalApi.ImageServer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Admin.EndPoint.Pages.CatalogItems
{
    [Authorize(Roles = "Administrator,Maneger")]
    public class CreateModel : PageModel
    {
        private readonly IAddNewCatalogItemService addNewCatalogItemService;
        private readonly ICatalogItemService catalogItemService;
        private readonly IUploadFile imageUploadService;
        private readonly IAddStoreroom addStoreroom;
        private readonly IGetUserToken getUserToken;

        public CreateModel(IAddNewCatalogItemService addNewCatalogItemService
            , ICatalogItemService catalogItemService
            , IUploadFile imageUploadService
            , IAddStoreroom addStoreroom
            , IGetUserToken getUserToken)
        {
            this.addNewCatalogItemService = addNewCatalogItemService;
            this.catalogItemService = catalogItemService;
            this.imageUploadService = imageUploadService;
            this.addStoreroom = addStoreroom;
            this.getUserToken = getUserToken;
        }

        public SelectList Categories { get; set; }
        public SelectList Brands { get; set; }
        public SelectList Companes { get; set; }
        public SelectList Cars { get; set; }

        [BindProperty]
        public AddNewCatalogItemDto Data { get; set; }
        [BindProperty]
        public List<IFormFile> Files { get; set; }


        public void OnGet()
        {
            Cars = new SelectList(catalogItemService.GetCares(), "Id", "Name");
            Companes = new SelectList(catalogItemService.GetCompanes(), "Id", "Name");
            Categories = new SelectList(catalogItemService.GetCatalogType(), "Id", "Type");
            Brands = new SelectList(catalogItemService.GetBrand(), "Id", "Brand");
        }



        public JsonResult OnPost()
        {
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
                var result = imageUploadService.UploadFileToServersResized(Files, 1000, 600);
                foreach (var item in result.FileNameAddress)
                {
                    images.Add(new AddNewCatalogItemImage_Dto { Src = item });
                }
            }
          
            Data.Images = images;
            var resultService = addNewCatalogItemService.Execute(Data);
            if (resultService.IsSuccess)
            {
                var userId = ClaimUtility.GetUserId(User);
                var result = addStoreroom.add(new AddStoreroomDto() { CatalogItemId = resultService.Data, StockCount = Data.AvailableStock, UserId = userId, Status = 1 });

            }
            return new JsonResult(resultService);
        }
    }
}
