using Application.Dtos;
using Application.Interfaces.Contexts;
using Application.Orders.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Orders.Query
{
   public interface ISaleReportQuery
    {
      ResultDto<FerstSaleReportQueryViewModel> FirstDefultSaleReport();
    }
    public class SaleReportQuery : ISaleReportQuery
    {
        private readonly IDataBaseContext _dbContext;

        public SaleReportQuery(IDataBaseContext DbContext)
        {
            _dbContext = DbContext;
        }

        public ResultDto<FerstSaleReportQueryViewModel> FirstDefultSaleReport()
        {
            DateTime start = DateTime.Now.Date;
            DateTime end = DateTime.Now.AddDays(1);
            //آمار   امروز 
            var TodayPageViewCount = _dbContext.Orders.AsQueryable()
    .Where(p => p.ZamanDelivered >= start && p.ZamanDelivered < end).Count();

            //آمار  در 1 روز گذشته 
            var YesterdayViewCount = _dbContext.Orders.AsQueryable()
                .Where(p => p.ZamanDelivered >= start.AddDays(-1) && p.ZamanDelivered < end.AddDays(-1)).Count();
            var TodayVisitorCount = _dbContext.Orders
                .Where(p => p.ZamanDelivered >= start.AddDays(-1) && p.ZamanDelivered < end.AddDays(-1)).GroupBy(p => p.UserId)
                .Count();
            var AllPageViewCount = _dbContext.MonthLogs.Sum(p => p.CountLog);
           
            //آمار  در 30 روز گذشته بر اساس کاربر منحصر به فرد
            var AllVisitorCountByVisitorId = _dbContext.Orders
                 .Where(p => p.ZamanDelivered >= DateTime.Now.AddDays(-30))
                .GroupBy(p => p.UserId).Count();

            //آمار  در 30 روز گذشته 
            var AllVisitorCountBy = _dbContext.Orders
                 .Where(p => p.ZamanDelivered >= DateTime.Now.AddDays(-30))
                .Count();


            return new ResultDto<FerstSaleReportQueryViewModel>();
        }
    }
}
