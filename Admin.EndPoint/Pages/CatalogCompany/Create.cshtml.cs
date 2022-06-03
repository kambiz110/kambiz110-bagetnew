using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Catalogs.CatalogCompany.CrudService;
using Application.Catalogs.CatalogCompany.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Admin.EndPoint.Pages.CatalogCompany
{
    public class CreateModel : PageModel
    {
        private readonly ICrudCompanyService crudCompanyService;
      
        public CreateModel(ICrudCompanyService crudCompanyService)
        {
            this.crudCompanyService = crudCompanyService;
        }
        [BindProperty]
        public CompanyDto CatalogCompany { get; set; } = new CompanyDto { };
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
    
            var result = crudCompanyService.Add(CatalogCompany);
            if (result.IsSuccess)
            {
                return RedirectToPage("index");
            }
            Message = result.Message;
            return Page();
        }
    }
}
