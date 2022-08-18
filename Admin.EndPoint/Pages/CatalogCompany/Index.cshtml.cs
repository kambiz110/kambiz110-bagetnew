using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Catalogs.CatalogCompany.CrudService;
using Application.Catalogs.CatalogCompany.Dto;
using Application.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Admin.EndPoint.Pages.CatalogCompany
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly ICrudCompanyService crudCompanyService;
        public PaginatedItemsDto<CompanyListDto> CatalogCompany { get; set; }
        public IndexModel(ICrudCompanyService crudCompanyService)
        {
            this.crudCompanyService = crudCompanyService;
        }

        public void OnGet( int pageIndex = 1, int pageSize = 10)
        {

            CatalogCompany = crudCompanyService.GetList( pageIndex, pageSize);
        }
    }
}
