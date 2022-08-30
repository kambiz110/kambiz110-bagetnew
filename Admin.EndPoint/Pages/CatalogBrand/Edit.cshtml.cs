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
    public class EditModel : PageModel
    {
        private readonly ICatalogBrandCrudService catalogBrandCrudService;

        public EditModel(ICatalogBrandCrudService catalogBrandCrudService)
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
                CatalogBrand = model.Data;
            Message = model.Message;
        }

        public IActionResult OnPost()
        {

            var result = catalogBrandCrudService.Edit(CatalogBrand);
            Message = result.Message;

            return Page();
        }
    }
}
