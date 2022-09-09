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

        public ReturndsController(IReturnedForAdminService returnedForAdmin)
        {
            this.returnedForAdmin = returnedForAdmin;
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
    }
}
