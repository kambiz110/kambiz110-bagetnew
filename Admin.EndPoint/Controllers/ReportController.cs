using Application.Logs.Query;
using Application.Orders.Dto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.EndPoint.Controllers
{
    public class ReportController : Controller
    {
        private readonly IGetUserlogs _getUserlogs;

        public ReportController(IGetUserlogs getUserlogs)
        {
            _getUserlogs = getUserlogs;
        }

        public IActionResult VisitorReport()
        {
            return View();
        }
        [HttpGet]
        public IActionResult UserLogs(int PageSize = 20, int PageNo = 1, string q = "", string search = "")
        {
            if (search == "clear")
            {
                return RedirectToAction("UserLogs");
            }
            var model = _getUserlogs.GetUserLogs(PageSize, PageNo, q);
            return View(model.Data);
        }
        [HttpGet]
        public IActionResult SaleReport(SaleReportDto dto)
        {
            return View();
        }
    }
}
