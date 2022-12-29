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

            model.Today = new BuyDto {
                BuyCount = TodayPageView.Count(),
                Buyers = TodayPageView.GroupBy(p => p.UserId).Count(),
                SaleReport = new BuyReportCountDto {
                    Value = SsaleReportToday.Select(o => new {
                        a = o.Select(p => p.OrderItems.Sum(o => o.UnitPrice * o.Units)).Sum(t => t)
                    }).Select(p => p.a).ToArray(),
                    Display = SsaleReportToday.Select(p => p.Key.ToPersianDateStrFarsi()).ToArray(),
                    BuyCount= SsaleReportToday.Select(p => new{ b=p.Count() }).Select(p => p.b).ToArray(),
                    UserCount = SsaleReportToday.Select(o => new {
                        a = o.GroupBy(p => p.UserId).Count()
                    }).Select(p => p.a).ToArray(),
                },
            };

  
            model.NowWeek = GetBuyPerDayDitelesWithStartEnd(DateTime.Now, 7);
            model.LastWeek = GetBuyPerDayDitelesWithStartEnd(DateTime.Now.AddDays(-7), 7);
            model.NowMonthd = GetBuyPerDayDitelesWithStartEnd(DateTime.Now, 30);
            model.LastMonthd = GetBuyPerDayDitelesWithStartEnd(DateTime.Now.AddDays(-30), 30);

            //آمار  در 1 روز گذشته 
            var YesterdayView = _dbContext.Orders.AsQueryable()
                .Where(p => p.OrderDate >= start.AddDays(-1)
                && p.OrderDate < end.AddDays(-1)
                && (int)p.PaymentStatus == 1).Include(p => p.OrderItems)
                       .OrderBy(p => p.OrderDate)
            .GroupBy(p => p.OrderDate.Date);
            return new ResultDto<FerstSaleReportQueryViewModel>() {
            IsSuccess=true,
            Data=model
            };

        }
        //result.SaleReport = visitPerDay;
        private BuyReportCountDto GetBuyPerDay(int countDay)
        {
            DateTime MonthStart = DateTime.Now.Date.AddDays(-(countDay));
            DateTime MonthEnds = DateTime.Now.Date.AddDays(1);
            var QueryPageView = _dbContext.Orders.Where(p => (int)p.PaymentStatus == 1).AsQueryable()
                .Include(p => p.OrderItems)
                .Where(p => p.OrderDate >= MonthStart && p.OrderDate < MonthEnds)
              .AsQueryable();
            BuyReportCountDto visitPerDay = new BuyReportCountDto() { Display = new string[countDay], Value = new int[countDay], UserCount = new int[countDay], BuyCount = new int[countDay] };
            for (int i = 0; i < countDay; i++)
            {
                var currentday = DateTime.Now.AddDays(i * (-1));
                var currentFarsiDay = currentday.ToPersianDateString();
                visitPerDay.Display[i] = currentFarsiDay;
                var query = QueryPageView.Where(p => p.OrderDate.Date == currentday.Date);
                if (QueryPageView.Where(p => p.OrderDate.Date == currentday.Date).Count() > 0)
                {
                   
                    visitPerDay.BuyCount[i] = query.GroupBy(p => p.UserId).Count();
                    visitPerDay.UserCount[i] = query.Count();
                    visitPerDay.Value[i] = query
                        .Select(p => p.OrderItems.Sum(o => o.UnitPrice * o.Units)).ToList().Sum(p => p);
                }
                else
                {
                    visitPerDay.BuyCount[i] = 0;
                    visitPerDay.UserCount[i] = 0;
                    visitPerDay.Value[i] =0;
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
            BuyReportCountDto visitPerDay = new BuyReportCountDto() { Display = new string[countDay], Value = new int[countDay] , UserCount= new int[countDay] , BuyCount= new int[countDay] };
            for (int i = 0; i < countDay; i++)
            {
                var currentday = start.AddDays(i * (-1));
                var currentFarsiDay = currentday.ToPersianDateString();
                visitPerDay.Display[i] = currentFarsiDay;
                var query = QueryPageView.Where(p => p.OrderDate.Date == currentday.Date);
                if (QueryPageView.Where(p => p.OrderDate.Date == currentday.Date).Count() > 0)
                {

                    visitPerDay.BuyCount[i] = query.GroupBy(p => p.UserId).Count();
                    visitPerDay.UserCount[i] = query.Count();
                    visitPerDay.Value[i] = query
                        .Select(p => p.OrderItems.Sum(o => o.UnitPrice * o.Units)).ToList().Sum(p => p);
                }
                else
                {
                    visitPerDay.BuyCount[i] = 0;
                    visitPerDay.UserCount[i] = 0;
                    visitPerDay.Value[i] = 0;
                }


            }
            return new BuyDto() { };
        }
    }

}
