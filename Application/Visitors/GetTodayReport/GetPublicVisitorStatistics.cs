using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Visitors.GetTodayReport
{
   public class GetPublicVisitorStatistics :ViewComponent
    {
        private readonly IGetTodayReportService _getTodayReport;

        public GetPublicVisitorStatistics(IGetTodayReportService getTodayReport)
        {
            _getTodayReport = getTodayReport;
        }

        public IViewComponentResult Invoke()
        {
            var result = _getTodayReport.Execute();
            var viewName = string.Format(
            "~/Views/Shared/Components/{0}.cshtml",
            this.ViewComponentContext.ViewComponentDescriptor.ShortName);
            return View(viewName, result);
        }
    }
}
