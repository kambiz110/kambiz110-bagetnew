using Application.Orders.Query;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.EndPoint.Helper.Component
{
    public class GetSaleReportView : ViewComponent
    {
        private readonly ISaleReportQuery _saleReportQuery;

        public GetSaleReportView(ISaleReportQuery saleReportQuery)
        {
            _saleReportQuery = saleReportQuery;
        }

        public IViewComponentResult Invoke()
        {
            var result = _saleReportQuery.FirstDefultSaleReport();
            var viewName = string.Format(
            "~/Views/Shared/Components/{0}.cshtml",
            this.ViewComponentContext.ViewComponentDescriptor.ShortName);
            return View(viewName, result.Data);
        }

    }
}
