using Application.Orders.Query;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.EndPoint.Helper.ViewComponents.SaleReport
{
    public class BuyReport :ViewComponent
    {
        private readonly ISaleReportQuery saleReportQuery;

        public BuyReport(ISaleReportQuery saleReportQuery)
        {
            this.saleReportQuery = saleReportQuery;
        }

        public IViewComponentResult Invoke()
        {
            var result = saleReportQuery.FirstDefultSaleReport();
            var viewName = string.Format(
            "~/Views/Shared/Components/{0}.cshtml",
            this.ViewComponentContext.ViewComponentDescriptor.ShortName);
            return View(viewName, result);
        }
    }
}
