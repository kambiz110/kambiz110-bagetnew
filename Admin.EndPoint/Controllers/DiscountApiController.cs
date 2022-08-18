using Application.Discounts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.EndPoint.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountApiController : ControllerBase
    {
        private readonly IDiscountService discountService;
        private readonly IDeletItemInDescount deletItemInDescount;

        public DiscountApiController(IDiscountService discountService , IDeletItemInDescount deletItemInDescount)
        {
            this.discountService = discountService;
            this.deletItemInDescount = deletItemInDescount;
        }


        [HttpGet]
        [Route("SearchCatalogItem")]
        public  IActionResult SearchCatalogItem(string term , int categoryId=0, int brandId=0, int carId=0)
        {
            var model =  discountService.GetCatalogItems(term , categoryId , brandId, carId);
            return Ok(model);
        }
        [HttpGet]
        [Route("DeletedDiscountItem")]
        public  IActionResult DeletedDiscountItem(int catalogItemId, int diccountId)
        {

            var result = deletItemInDescount.delete(diccountId, catalogItemId);
            var sum = (catalogItemId + diccountId);
            return Ok("Succes : "+ sum+"");
        }
    }
}
