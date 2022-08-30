using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Catalogs.CatalogCars.CrudService;
using Application.Catalogs.CatalogCars.Dto;
using Application.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Admin.EndPoint.Pages.CatologCar
{
    [Authorize(Roles = "Administrator,Maneger")]
    public class IndexModel : PageModel
    {
        private readonly ICrudCarService crudCompanyService;
        public PaginatedItemsDto<CarListDto> CatalogCompany { get; set; }
        public IndexModel(ICrudCarService crudCompanyService)
        {
            this.crudCompanyService = crudCompanyService;
        }

        public void OnGet( int pageIndex = 1, int pageSize = 10)
        {

            CatalogCompany = crudCompanyService.GetList( pageIndex, pageSize);
        }
    }
}
