using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.EndPoint.Helper;
using Application.Banners;
using Application.Users.Token;
using Infrastructure.ExternalApi.ImageServer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Admin.EndPoint.Pages.Banners
{
    public class EditModel : PageModel
    {
        private readonly IBannersService banners;
        private readonly IImageUploadService imageUploadService;
        private readonly IGetUserToken getUserToken;

        public EditModel(IBannersService banners,
            IImageUploadService imageUploadService, IGetUserToken getUserToken)
        {
            this.banners = banners;
            this.imageUploadService = imageUploadService;
            this.getUserToken = getUserToken;
        }
        public List<String> Message { get; set; } = new List<string>();
        [BindProperty]
        public BannerDto Banner { get; set; }
        [BindProperty]
        public IFormFile BannerImage { get; set; }


        public void OnGet(int Id)
        {
            var model = banners.FindById(Id);
            if (model.IsSuccess)
                Banner = model.Data;
            Message = model.Message;
        }
        public IActionResult OnPost()
        {
            //Upload 
            if (BannerImage!=null && BannerImage.Length>0)
            {
                var result = imageUploadService.Upload(new List<IFormFile> { BannerImage }, ClaimUtility.GetUserId(User), getUserToken.getToken(User.Identity.Name));
                if (result.Count > 0)
                {
                    Banner.Image = result.FirstOrDefault();
                    banners.Edit(Banner);
                }
                return RedirectToPage("Index");
            }

          
             
                banners.Edit(Banner);
           
            return RedirectToPage("Index");

        }
    }
}
