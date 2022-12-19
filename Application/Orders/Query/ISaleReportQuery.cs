using Application.Dtos;
using Application.Interfaces.Contexts;
using Application.Orders.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Useful;

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
            var model = new FerstSaleReportQueryViewModel();
            DateTime start = DateTime.Now.Date;
            DateTime end = DateTime.Now.AddDays(1);
            //آمار   امروز 
            var TodayPageView = _dbContext.Orders.AsQueryable()
                 .Where(p => (int)p.PaymentStatus == 1)
            //   .Where(p => p.OrderDate >= start && p.OrderDate < end
            //  && (int)p.PaymentStatus == 1)
            .Include(p => p.OrderItems)
            .OrderBy(p => p.OrderDate).ToList();

            var SsaleReportToday= TodayPageView.GroupBy(p=>p.OrderDate.Date);

            model.Today = new BuyDto {
                BuyCount = TodayPageView.Count(),
                Buyers = TodayPageView.GroupBy(p => p.UserId).Count(),
                SaleReport = new BuyReportCountDto {
                    Value = SsaleReportToday.Select(o => new {
                        a = o.Select(p => p.OrderItems.Sum(o => o.UnitPrice * o.Units)).Sum(t => t)
                    }).Select(p => p.a).ToArray(),
                    Display= SsaleReportToday.Select(p=>p.Key.ToPersianDateStrFarsi()).ToArray(),
                },
                 };
            //آمار  در 1 روز گذشته 
            var YesterdayView = _dbContext.Orders.AsQueryable()
                .Where(p => p.OrderDate >= start.AddDays(-1)
                && p.OrderDate < end.AddDays(-1)
                && (int)p.PaymentStatus == 1).Include(p => p.OrderItems)
                       .OrderBy(p => p.OrderDate)
            .GroupBy(p => p.OrderDate.Date);

            //آمار  در 7 روز گذشته 
            var SevendayView = _dbContext.Orders.AsQueryable()
                .Where(p => p.OrderDate >= start.AddDays(-1)
                && p.OrderDate < end.AddDays(-7)
                && (int)p.PaymentStatus == 1).Include(p => p.OrderItems)
                       .OrderBy(p => p.OrderDate)
            .GroupBy(p => p.OrderDate.Date);



            //آمار  در 30 روز گذشته بر اساس کاربر منحصر به فرد
            var AllVisitorCountByVisitorId = _dbContext.Orders
                 .Where(p => p.OrderDate >= DateTime.Now.AddDays(-30))
                .GroupBy(p => p.UserId).Count();

            //آمار  در 30 روز گذشته 
            var BuyThirtyDay = _dbContext.Orders
                 .Where(p => p.OrderDate >= DateTime.Now.AddDays(-30)
                 && (int)p.PaymentStatus == 1)
                .Include(p => p.OrderItems)
                   .OrderBy(p => p.OrderDate)
            .GroupBy(p => p.OrderDate.Date);

            return new ResultDto<FerstSaleReportQueryViewModel>();
        }
    }
}
