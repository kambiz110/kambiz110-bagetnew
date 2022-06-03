using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Catalogs.CatalogBrands;
using Application.Catalogs.CatalohItems.CatalogItemServices;
using Application.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Admin.EndPoint.Pages.CatalogBrand
{
    public class IndexModel : PageModel
    {
        private readonly ICatalogBrandCrudService catalogBrandCrudService;

        public IndexModel(ICatalogBrandCrudService catalogBrandCrudService)
        {
            this.catalogBrandCrudService = catalogBrandCrudService;
        }
        public PaginatedItemsDto<CatalogBrandDto> CatalogBrandes { get; set; }
        public void OnGet(int pageIndex = 1, int pageSize = 10)
        {

            CatalogBrandes = catalogBrandCrudService.GetList(pageIndex, pageSize);
        }
    }
}
