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
    public class DeleteModel : PageModel
    {
        private readonly ICrudCompanyService crudCompanyService;

        public DeleteModel(ICrudCompanyService crudCompanyService)
        {
            this.crudCompanyService = crudCompanyService;
        }
        [BindProperty]
        public CompanyDto CatalogCompany { get; set; } = new CompanyDto { };
        public List<String> Message { get; set; } = new List<string>();
        public void OnGet(int Id)
        {
            var model = crudCompanyService.FindById(Id);
            if (model.IsSuccess)
                CatalogCompany = (model.Data);
            Message = model.Message;
        }

        public IActionResult OnPost()
        {
            var result = crudCompanyService.Remove(CatalogCompany.Id);
            Message = result.Message;
            if (result.IsSuccess)
            {
                return RedirectToPage("index");
            }
            return Page();
        }
    }
}
