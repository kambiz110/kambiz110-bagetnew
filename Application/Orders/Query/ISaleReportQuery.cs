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

            var SsaleReportToday = TodayPageView.GroupBy(p => p.OrderDate.Date);

            model.Today = GetBuyPerDayDiteles(7);
            var SevenDay = GetBuyPerDayDitelesWithStartEnd(DateTime.Now.AddDays(-7) , 7);
            var buycount = GetBuyPerDayCount(7);
            var BuyPerDay = GetBuyPerDay(7);

            //آمار  در 30 روز گذشته بر اساس کاربر منحصر به فرد
            //var AllVisitorCountByVisitorId = _dbContext.Orders
            //     .Where(p => p.OrderDate >= DateTime.Now.AddDays(-30))
            //    .GroupBy(p => p.UserId).Count();

    

            return new ResultDto<FerstSaleReportQueryViewModel>();
        }
        private BuyReportCountDto GetBuyPerDayCount(int countDay = 30)
        {
            DateTime MonthStart = DateTime.Now.Date.AddDays(-(countDay));
            DateTime MonthEnds = DateTime.Now.Date.AddDays(1);
            var QueryPageView = _dbContext.Orders.Where(p => (int)p.PaymentStatus == 1).AsQueryable()
             .Where(p => p.OrderDate >= MonthStart && p.OrderDate < MonthEnds)
                .Select(p => new { p.OrderDate })
                .ToList();
            BuyReportCountDto visitPerDay = new BuyReportCountDto() { Display = new string[countDay], Value = new int[countDay] };
            for (int i = 0; i < countDay; i++)
            {
                var currentday = DateTime.Now.AddDays(i * (-1));
                var currentFarsiDay = currentday.ToPersianDateString();
                visitPerDay.Display[i] = currentFarsiDay;
                visitPerDay.Value[i] = QueryPageView.Where(p => p.OrderDate.Date == currentday.Date).Count();
            }

            return visitPerDay;
        }
        private BuyDto GetBuyPerDayDiteles(int countDay)
        {
            DateTime MonthStart = DateTime.Now.Date.AddDays(-(countDay));
            DateTime MonthEnds = DateTime.Now.Date.AddDays(1);
          
            var QueryPageView = _dbContext.Orders.AsQueryable()
                 .Where(p => (int)p.PaymentStatus == 1 &&
                 p.OrderDate >= MonthStart &&
                 p.OrderDate < MonthEnds)
                .Include(p => p.OrderItems)
                .OrderBy(p => p.OrderDate).AsQueryable();

            var SsaleReportToday = QueryPageView.GroupBy(p => p.OrderDate.Date);
            var result = new BuyDto();
            result.BuyCount = QueryPageView.Count();
            result.Buyers = QueryPageView.GroupBy(p => p.UserId).Count();
            BuyReportCountDto visitPerDay = new BuyReportCountDto() { Display = new string[countDay], Value = new int[countDay] };
            for (int i = 0; i < countDay; i++)
            {
                var currentday = DateTime.Now.AddDays(i * (-1));
                var currentFarsiDay = currentday.ToPersianDateString();
                visitPerDay.Display[i] = currentFarsiDay;
                if (QueryPageView.Where(p => p.OrderDate.Date == currentday.Date).Count() > 0)
                {
                    visitPerDay.Value[i] = QueryPageView.Where(p => p.OrderDate.Date == currentday.Date)
                        .Select(p => p.OrderItems.Sum(o => o.UnitPrice * o.Units)).ToList().Sum(p => p);
                }
                else
                {
                    visitPerDay.Value[i] = QueryPageView.Where(p => p.OrderDate.Date == currentday.Date).Count();
                }

            }
            result.SaleReport = visitPerDay;
            return result;
        }
        private BuyReportCountDto GetBuyPerDay(int countDay)
        {
            DateTime MonthStart = DateTime.Now.Date.AddDays(-(countDay));
            DateTime MonthEnds = DateTime.Now.Date.AddDays(1);
            var QueryPageView = _dbContext.Orders.Where(p=> (int)p.PaymentStatus == 1 ).AsQueryable()
                .Include(p => p.OrderItems)
                .Where(p => p.OrderDate >= MonthStart && p.OrderDate < MonthEnds)
              .AsQueryable();
            BuyReportCountDto visitPerDay = new BuyReportCountDto() { Display = new string[countDay], Value = new int[countDay] };
            for (int i = 0; i < countDay; i++)
            {
                var currentday = DateTime.Now.AddDays(i * (-1));
                var currentFarsiDay = currentday.ToPersianDateString();
                visitPerDay.Display[i] = currentFarsiDay;
                if (QueryPageView.Where(p => p.OrderDate.Date == currentday.Date).Count() > 0)
                {
                    visitPerDay.Value[i] = QueryPageView.Where(p => p.OrderDate.Date == currentday.Date)
                        .Select(p => p.OrderItems.Sum(o => o.UnitPrice * o.Units)).ToList().Sum(p=>p);
                }
                else
                {
                    visitPerDay.Value[i] = QueryPageView.Where(p => p.OrderDate.Date == currentday.Date).Count();
                }

            }

            return visitPerDay;
        }

        private BuyDto GetBuyPerDayDitelesWithStartEnd(DateTime start, int countDay)
        {
            DateTime MonthStart = start;
            DateTime MonthEnds = start.AddDays(-(countDay));

            var QueryPageView = _dbContext.Orders.AsQueryable()
                 .Where(p => (int)p.PaymentStatus == 1 &&
                 p.OrderDate >= MonthStart &&
                 p.OrderDate < MonthEnds)
                .Include(p => p.OrderItems)
                .OrderBy(p => p.OrderDate).AsQueryable();

            var SsaleReportToday = QueryPageView.GroupBy(p => p.OrderDate.Date);
            var result = new BuyDto();
            result.BuyCount = QueryPageView.Count();
            result.Buyers = QueryPageView.GroupBy(p => p.UserId).Count();
            BuyReportCountDto visitPerDay = new BuyReportCountDto() { Display = new string[countDay], Value = new int[countDay] };
            for (int i = 0; i < countDay; i++)
            {
                var currentday = start.AddDays(i * (-1));
                var currentFarsiDay = currentday.ToPersianDateString();
                visitPerDay.Display[i] = currentFarsiDay;
                if (QueryPageView.Where(p => p.OrderDate.Date == currentday.Date).Count() > 0)
                {
                    visitPerDay.Value[i] = QueryPageView.Where(p => p.OrderDate.Date == currentday.Date)
                        .Select(p => p.OrderItems.Sum(o => o.UnitPrice * o.Units)).ToList().Sum(p => p);
                }
                else
                {
                    visitPerDay.Value[i] = QueryPageView.Where(p => p.OrderDate.Date == currentday.Date).Count();
                }

            }
            result.SaleReport = visitPerDay;
            return result;
        }
    }
}
