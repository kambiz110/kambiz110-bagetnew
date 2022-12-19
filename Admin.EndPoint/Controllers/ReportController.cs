using Application.Logs.Query;
using Application.Orders.Dto;
using Application.Orders.Query;
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
        private readonly ISaleReportQuery _saleReportQuery;

        public ReportController(IGetUserlogs getUserlogs, ISaleReportQuery saleReportQuery)
        {
            _getUserlogs = getUserlogs;
            _saleReportQuery = saleReportQuery;
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
            var test = _saleReportQuery.FirstDefultSaleReport();
            return View();
        }
    }
}
