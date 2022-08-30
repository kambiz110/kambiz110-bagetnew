using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Catalogs.CatalogTypes;
using Application.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Admin.EndPoint.Pages.CatalogType
{
    [Authorize(Roles = "Administrator,Maneger")]
    public class IndexModel : PageModel
    {
        private readonly ICatalogTypeService catalogTypeService;

        public IndexModel(ICatalogTypeService catalogTypeService)
        {
            this.catalogTypeService = catalogTypeService;
        }

        public PaginatedItemsDto<CatalogTypeListDto> CataolType { get; set; }
        public int? GetparentId { get; set; }
        public void OnGet(int? parentId, int pageIndex = 1, int pageSize = 10)
        {
            GetparentId = parentId;
            CataolType = catalogTypeService.GetList(parentId, pageIndex, pageSize);
        }
    }
}
