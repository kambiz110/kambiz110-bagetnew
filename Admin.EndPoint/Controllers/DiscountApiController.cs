using Application.Discounts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.EndPoint.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountApiController : ControllerBase
    {
        private readonly IDiscountService discountService;

        public DiscountApiController(IDiscountService discountService)
        {
            this.discountService = discountService;
        }


        [HttpGet]
        [Route("SearchCatalogItem")]
        public  IActionResult SearchCatalogItem(string term , int categoryId=0, int brandId=0)
        {
            var model =  discountService.GetCatalogItems(term , categoryId , brandId);
            return Ok(model);
        }
    }
}
