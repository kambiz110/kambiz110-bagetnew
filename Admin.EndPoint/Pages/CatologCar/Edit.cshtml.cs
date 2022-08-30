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
    public class EditModel : PageModel
    {
        private readonly ICrudCarService crudCompanyService;

        public EditModel(ICrudCarService crudCompanyService)
        {
            this.crudCompanyService = crudCompanyService;
        }
        [BindProperty]
        public CarDto CatalogCompany { get; set; } = new CarDto { };
        public List<String> Message { get; set; } = new List<string>();
        public void OnGet(int Id)
        {
            var model = crudCompanyService.FindById(Id);
            if (model.IsSuccess)
                CatalogCompany = model.Data;
             Message = model.Message;
        }

        public IActionResult OnPost()
        {

            var result = crudCompanyService.Edit(CatalogCompany);
            Message = result.Message;
         
            return Page();
        }
    }
}
