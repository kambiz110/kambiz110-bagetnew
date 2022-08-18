using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Banners;
using Application.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Admin.EndPoint.Pages.Banners
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly IBannersService bannersService;

        public IndexModel(IBannersService banners)
        {
            this.bannersService = banners;
        }
        public PaginatedItemsDto<BannerDto> PaginatedItems { get; set; }
        public void OnGet(int pageIndex = 1, int pageSize = 10)
        {

            PaginatedItems = bannersService.GetList(pageIndex, pageSize);
        }
    }
}
