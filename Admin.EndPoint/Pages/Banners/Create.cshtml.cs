using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.EndPoint.Helper;
using Admin.EndPoint.Helper.UploadFile;
using Application.Banners;
using Application.Users.Token;
using Infrastructure.ExternalApi.ImageServer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Admin.EndPoint.Pages.Banners
{
    [Authorize(Roles = "Administrator,Maneger")]
    public class CreateModel : PageModel
    {
        private readonly IBannersService banners;
        private readonly IUploadFile imageUploadService;
        private readonly IGetUserToken getUserToken;

        public CreateModel(IBannersService banners,
            IUploadFile imageUploadService, IGetUserToken getUserToken)
        {
            this.banners = banners;
            this.imageUploadService = imageUploadService;
            this.getUserToken = getUserToken;
        }


        [BindProperty]
        public BannerDto Banner { get; set; }
        [BindProperty]
        public IFormFile BannerImage { get; set; }



        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (BannerImage != null && BannerImage.Length > 0)
            {
                var result = imageUploadService.UploadFileToServers(new List<IFormFile> { BannerImage });
                if (result.FileNameAddress.Count > 0)
                {
                    Banner.Image = result.FileNameAddress.FirstOrDefault();
                    banners.AddBanner(Banner);
                }
                return RedirectToPage("Index");
            }
            Banner.Image = null;
            banners.AddBanner(Banner);
      
            return RedirectToPage("Index");

        }
    }
}
