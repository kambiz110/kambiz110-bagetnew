using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Catalogs.CatalogCars.CrudService;
using Application.Catalogs.CatalogCars.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Admin.EndPoint.Pages.CatologCar
{
    [Authorize(Roles = "Administrator,Maneger")]
    public class CreateModel : PageModel
    {
        private readonly ICrudCarService crudCompanyService;
      
        public CreateModel(ICrudCarService crudCompanyService)
        {
            this.crudCompanyService = crudCompanyService;
        }
        [BindProperty]
        public CarDto CatalogCompany { get; set; } = new CarDto { };
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
