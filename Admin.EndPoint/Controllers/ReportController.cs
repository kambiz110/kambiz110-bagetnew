using Application.Logs.Query;
using Application.Orders.Dto;
using Application.Orders.Query;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.EndPoint.Helper;
using Application.Dtos;

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
        public IActionResult SaleReport()
        {
          //  var test = _saleReportQuery.FirstDefultSaleReport();
            return View();
        }

        [HttpGet]
        public IActionResult AjaxSaleReport(SaleReportDto dto)
        {
       
                var result = _saleReportQuery.FirstDefultSaleReport();
            if (result.IsSuccess)
            {
              
                var viewHtml = this.RenderViewAsync("_Partial_AjaxSaleReport", result.Data, true);
                return Json(new ResultDto<string>
                {
                    Data = viewHtml,
                    IsSuccess = true,
                    Message = " گزارش گیری موفق ."
                }); ;
            }
            return Json(new ResultDto<string>
            {
                Data = "<h1>گزارش ناموفق.</h1>",
                IsSuccess = false,
                Message = "ناموفق."
            });
    
        }
    }
}
