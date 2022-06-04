using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Banners;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Admin.EndPoint.Pages.Banners
{
    public class DeleteModel : PageModel
    {
        private readonly IBannersService bannersService;

        public DeleteModel(IBannersService banners)
        {
            this.bannersService = banners;

        }
        [BindProperty]
        public BannerDto Banner { get; set; } = new BannerDto { };
        public List<String> Message { get; set; } = new List<string>();
        public void OnGet(int Id)
        {
            var model = bannersService.FindById(Id);
            if (model.IsSuccess)
                Banner = (model.Data);
            Message = model.Message;
        }

        public IActionResult OnPost()
        {
            var result = bannersService.Remove(Banner.Id);
            Message = result.Message;
            if (result.IsSuccess)
            {
                return RedirectToPage("index");
            }
            return Page();
        }
    }
}
