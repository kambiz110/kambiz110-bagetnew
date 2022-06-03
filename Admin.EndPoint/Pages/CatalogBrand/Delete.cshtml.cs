using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Catalogs.CatalogBrands;
using Application.Catalogs.CatalohItems.CatalogItemServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Admin.EndPoint.Pages.CatalogBrand
{
    public class DeleteModel : PageModel
    {
        private readonly ICatalogBrandCrudService catalogBrandCrudService;

        public DeleteModel(ICatalogBrandCrudService catalogBrandCrudService)
        {
            this.catalogBrandCrudService = catalogBrandCrudService;
        }
        [BindProperty]
        public CatalogBrandDto CatalogBrand { get; set; } = new CatalogBrandDto { };
        public List<String> Message { get; set; } = new List<string>();
        public void OnGet(int Id)
        {
            var model = catalogBrandCrudService.FindById(Id);
            if (model.IsSuccess)
                CatalogBrand = (model.Data);
            Message = model.Message;
        }

        public IActionResult OnPost()
        {
            var result = catalogBrandCrudService.Remove(CatalogBrand.Id);
            Message = result.Message;
            if (result.IsSuccess)
            {
                return RedirectToPage("index");
            }
            return Page();
        }
    }
}
