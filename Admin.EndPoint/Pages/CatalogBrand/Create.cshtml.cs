using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Catalogs.CatalogBrands;
using Application.Catalogs.CatalohItems.CatalogItemServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Admin.EndPoint.Pages.CatalogBrand
{
    [Authorize(Roles = "Administrator,Maneger")]
    public class CreateModel : PageModel
    {
        private readonly ICatalogBrandCrudService catalogBrandCrudService;

        public CreateModel(ICatalogBrandCrudService catalogBrandCrudService)
        {
            this.catalogBrandCrudService = catalogBrandCrudService;
        }
        [BindProperty]
        public CatalogBrandDto CatalogBrand { get; set; } = new CatalogBrandDto { };
        public List<String> Message { get; set; } = new List<string>();
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var result = catalogBrandCrudService.Add(CatalogBrand);
            if (result.IsSuccess)
            {
                return RedirectToPage("index");
            }
            Message = result.Message;
            return Page();
        }
    }
}
