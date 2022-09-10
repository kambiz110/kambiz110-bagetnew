using Application.PostalProducts;
using Application.PostalProducts.Dto;
using Application.Returneds.Query;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.EndPoint.Controllers
{
    [Authorize(Roles = "Administrator,Maneger")]
    public class ReturndsController : Controller
    {
        private readonly IReturnedForAdminService returnedForAdmin;
        private readonly IAddPostalProductService addPostalProduct;

        public ReturndsController(IReturnedForAdminService returnedForAdmin, IAddPostalProductService addPostalProduct)
        {
            this.returnedForAdmin = returnedForAdmin;
            this.addPostalProduct = addPostalProduct;
        }
        public IActionResult Index(int orderStatus = 0)
        {
            var model = returnedForAdmin.GetMyReturneds(orderStatus);
            return View(model);
        }
        [Route("Returnds/ReturndDetails/{returnedId}")]
        public IActionResult ReturndDetails(int returnedId)
        {
            var model = returnedForAdmin.GetAdminOrderDitales(returnedId);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> ReturndPostals(AddReturnedPostalProductDto dto)
        {
             await addPostalProduct.ReturnedPostal(dto);
            return RedirectToAction("Index");
        }
    }
}
