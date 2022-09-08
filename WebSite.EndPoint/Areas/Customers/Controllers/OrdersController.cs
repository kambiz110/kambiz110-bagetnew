using Application.Dtos;
using Application.Orders.CustomerOrdersServices;
using Application.Returneds.Command;
using Application.Returneds.Query;
using Domain.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSite.EndPoint.Utilities;

namespace WebSite.EndPoint.Areas.Customers.Controllers
{
    [Authorize]
    [Area("Customers")]
    public class OrdersController : Controller
    {
        private readonly ICustomerOrdersService customerOrdersService;
        private readonly UserManager<User> userManager;
        private readonly IReturnedOrderItemService returnedOrder;
        private readonly IReturnedForCustomerService returnedForCustomer;

        public OrdersController(ICustomerOrdersService customerOrdersService
            , UserManager<User> userManager
            , IReturnedOrderItemService returnedOrder
            , IReturnedForCustomerService returnedForCustomer)
        {
            this.customerOrdersService = customerOrdersService;
            this.userManager = userManager;
            this.returnedOrder = returnedOrder;
            this.returnedForCustomer = returnedForCustomer;
        }
        public IActionResult Index()
        {
            var user = userManager.GetUserAsync(User).Result;
            var orders = customerOrdersService.GetMyOrder(user.Id);
            return View(orders);
        }
        [Route("Customers/orders/ChangeOrederStat/{orderId}/{status}")]
        public async Task<IActionResult> ChangeOrederStat(int orderId, int status)
        {
            var user = userManager.GetUserAsync(User).Result;
            await customerOrdersService.chengeOrederStatuse(orderId, status, user.Id);
            return RedirectToAction("Index");
        }
        [Route("Customers/Orders/OrderDetails/{PaymentId}")]
        public IActionResult OrderDetails(Guid PaymentId)
        {
            var model = customerOrdersService.GetCustomerOrderDitales(PaymentId);
            return View(model);
        }
        [Route("Customers/Orders/ReturneDetails/{returnedId}")]
        public IActionResult ReturneDetails(int returnedId)
        {
            string userId = ClaimUtility.GetUserId(User);
            var model = returnedForCustomer.GetCustomerOrderDitales(returnedId , userId);
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ReturnedOrederItem(int[] orderItemsIds, int orederId)
        {
            if (!ModelState.IsValid)
            {
                return new JsonResult(new ResultDto { IsSuccess = false, Message = "false" });
            }
            string userId = ClaimUtility.GetUserId(User);
            var result = returnedOrder.ReturnedOrderItem(orderItemsIds, orederId, userId);
            return new JsonResult(result);
        }
    }
}
