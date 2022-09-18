using Application.Dtos;
using Application.Orders.AdminOrderServices;
using Application.PostalProducts;
using Application.PostalProducts.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.EndPoint.Controllers
{
    [Authorize(Roles = "Administrator,Maneger")]
    public class OrdersController : Controller
    {
        private readonly IAdminOrdersService adminOrdersService;
        private readonly IAddPostalProductService addPostalProduct;

        public OrdersController(IAdminOrdersService adminOrdersService, IAddPostalProductService addPostalProduct)
        {
            this.adminOrdersService = adminOrdersService;
            this.addPostalProduct = addPostalProduct;
        }
        public IActionResult Index(string searchkey = "", int orderStatus = 0)
        {
            var model = adminOrdersService.GetShopAdminOrder(searchkey, orderStatus);
            return View(model);
        }
        [Route("Orders/OrderDetails/{PaymentId}")]
        public IActionResult OrderDetails(Guid PaymentId)
        {
            var model = adminOrdersService.GetAdminOrderDitales(PaymentId);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> OrderPostals(AddPostalProductDto dto)
        {
            await addPostalProduct.addPostal(dto);
            return RedirectToAction("Index");
        }
        [Route("Orders/InvoiceOrder/{PaymentId}")]
        [HttpGet]
        public IActionResult InvoiceOrder(Guid PaymentId)
        {
            var model = adminOrdersService.GetAdminOrderDitales(PaymentId);
            return View(model);
        }
        [HttpGet]
        public IActionResult DeliveredProductToCustomer(int OrderId)
        {
            adminOrdersService.chengeOrederStatuse(OrderId ,2);
            return new JsonResult(new ResultDto { IsSuccess = true, Message = "true" });
        }
    }
}
