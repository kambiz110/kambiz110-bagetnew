using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Catalogs.CatalohItems.CatalogItemServices;
using Application.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Admin.EndPoint.Pages.CatalogItems
{
    public class IndexModel : PageModel
    {
        private readonly ICatalogItemService catalogItemService;

        public IndexModel(ICatalogItemService catalogItemService)
        {
            this.catalogItemService = catalogItemService;
        }
        public PaginatedItemsDto<CatalogItemListItemDto> CatalogItems { get; set; }
        public SelectList Categories { get; set; }
        public SelectList Brands { get; set; }
        public SelectList Companes { get; set; }
        public SelectList Cars { get; set; }
        public void OnGet(int page = 1, int pageSize = 100)
        {
            CatalogItems = catalogItemService.GetCatalogList(page, pageSize ,null);
        }
    }
}
