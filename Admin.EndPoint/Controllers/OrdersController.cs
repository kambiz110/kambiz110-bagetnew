using Application.Orders.AdminOrderServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.EndPoint.Controllers
{
    [Authorize]
    public class OrdersController : Controller
    {
        private readonly IAdminOrdersService adminOrdersService;

        public OrdersController(IAdminOrdersService adminOrdersService)
        {
            this.adminOrdersService = adminOrdersService;
        }
        public IActionResult Index(string searchkey="", int orderStatus=0)
        {
            var model = adminOrdersService.GetShopAdminOrder(searchkey, orderStatus);
            return View(model);
        }
    }
}
