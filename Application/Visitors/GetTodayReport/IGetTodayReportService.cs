using Application.Interfaces.Contexts;
using Common.Useful;
using Domain.Visitors;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Application.Visitors.GetTodayReport
{
    public interface IGetTodayReportService
    {
        ResultTodayReportDto Execute();
    }

    public class GetTodayReportService : IGetTodayReportService
    {
        private readonly IDataBaseContext _dbContext;

        public GetTodayReportService(IDataBaseContext DbContext)
        {
            _dbContext = DbContext;
        }

        public ResultTodayReportDto Execute()
        {
            DateTime start = DateTime.Now.Date;
            DateTime end = DateTime.Now.AddDays(1);

            var TodayPageViewCount = _dbContext.Visitors.AsQueryable()
                .Where(p => p.Time >= start && p.Time < end).Count();
            var TodayVisitorCount = _dbContext.Visitors
                .Where(p => p.Time >= start && p.Time < end).GroupBy(p => p.VisitorId)
                .LongCount();
            var AllPageViewCount = _dbContext.Visitors.Count();
            var AllVisitorCount = _dbContext.Visitors
                .GroupBy(p => p.VisitorId).Count();

            VisitCountDto visitPerHour = GTetVisitPerHour(start, end);

            VisitCountDto visitPerDay = GetVisitPerDay();


            //لینک هایی که بیشترین بازدید امروز را داشته اند

            var TodayVisitorPostMostViewed = MostVisitPostByDate(start, end, 10);

            //لینک هایی که بیشترین بازدید دیروز را داشته اند

            var YesterdayVisitorPostMostViewed = MostVisitPostByDate(start.AddDays(-1), end.AddDays(-1), 10);
            //بازدید های امروز بر اساس ساعت بازدید
            VisitCountDto TodayvisitPerHour = GTetVisitPerHour(start, end);
            //بازدید های دیروز بر اساس ساعت بازدید
            VisitCountDto YesterDayvisitPerHour = GTetVisitPerHour(start.AddDays(-1), end.AddDays(-1));

            //بازدید های دیروز بر اساس ساعت بازدید
            VisitCountDto TwoDayEgovisitPerHour = GTetVisitPerHour(start.AddDays(-2), end.AddDays(-2));

            //بازدید های 3 روز قبل
            VisitCountDto ThreeDayEgovisitPerHour = GTetVisitPerHour(start.AddDays(-3), end.AddDays(-3));

            //بازدید های 4 روز قبل
            VisitCountDto FourDayEgovisitPerHour = GTetVisitPerHour(start.AddDays(-4), end.AddDays(-4));
            //بازدید های 5 روز قبل
            VisitCountDto FiveDayEgovisitPerHour = GTetVisitPerHour(start.AddDays(-5), end.AddDays(-5));

            VisitCountDto visitPerDay30 = GetVisitPerDay(30);
            VisitCountDto visitHourPerDayes30 = GetVisitHourPerDays(30);


            var visitors = _dbContext.Visitors
                .OrderByDescending(p => p.Time)
                .Take(10)
                .Select(p => new VisitorsDto
                {
                    Id = p.Id,
                    Browser = p.BrowserFamily,
                    CurrentLink = p.CurrentLink,
                    Ip = p.Ip,
                    OperationSystem = p.OperationSystemFamily,
                    IsSpider = p.DeviceIsSpider,
                    ReferrerLink = p.ReferrerLink,
                    Time = p.Time,
                    VisitorId = p.VisitorId
                }).ToList();
            return new ResultTodayReportDto
            {
                GeneralStats = new GeneralStatsDto
                {
                    TotalVisitors = AllVisitorCount,
                    TotalPageViews = AllPageViewCount,
                    PageViewsPerVisit = GetAvg(AllPageViewCount, AllVisitorCount),
                    VisitPerDay = visitPerDay30,
                    VisitHourPerDayes = visitHourPerDayes30
                },
                Today = new TodayDto
                {
                    PageViews = TodayPageViewCount,
                    Visitors = TodayVisitorCount,
                    ViewsPerVisitor = GetAvg(TodayPageViewCount, TodayVisitorCount),
                    VisitPerhour = visitPerHour,
                },
                YesterDayVisit = new TodayDto
                {
                    VisitPerhour = YesterDayvisitPerHour,
                },
                TwoDayEgoVisit = new TodayDto
                {
                    VisitPerhour = TwoDayEgovisitPerHour,
                },
                ThreeDayEgoVisit = new TodayDto
                {
                    VisitPerhour = ThreeDayEgovisitPerHour,
                },
                FourDayEgoVisit = new TodayDto
                {
                    VisitPerhour = FourDayEgovisitPerHour,
                },
                FiveDayEgoVisit = new TodayDto
                {
                    VisitPerhour = FiveDayEgovisitPerHour,
                },
         
                visitors = visitors,
                TodayMostVisitedLink = TodayVisitorPostMostViewed,
                YesterdayMostVisitedLink = YesterdayVisitorPostMostViewed
            };
        }
        private VisitCountDto GetVisitPerDay(int countDay = 30)
        {
            DateTime MonthStart = DateTime.Now.Date.AddDays(-(countDay));
            DateTime MonthEnds = DateTime.Now.Date.AddDays(1);
            var Month_PageViewList = _dbContext.Visitors.AsQueryable()
                .Where(p => p.Time >= MonthStart && p.Time < MonthEnds)
                .Select(p => new { p.Time })
                .ToList();
            VisitCountDto visitPerDay = new VisitCountDto() { Display = new string[31], Value = new int[31] };
            for (int i = 0; i <= 30; i++)
            {
                var currentday = DateTime.Now.AddDays(i * (-1));
                var currentFarsiDay = DateTime.Now.AddDays(i * (-1)).ToPersianDateString();
                visitPerDay.Display[i] = currentFarsiDay;
                visitPerDay.Value[i] = Month_PageViewList.Where(p => p.Time.Date == currentday.Date).Count();
            }

            return visitPerDay;
        }

        private VisitCountDto GetVisitHourPerDays(int countDay = 30)
        {
            DateTime MonthStart = DateTime.Now.Date.AddDays(-countDay);
            DateTime MonthEnds = DateTime.Now.Date.AddDays(1);
            var Month_PageViewList = _dbContext.Visitors.AsQueryable()
                .Where(p => p.Time >= MonthStart && p.Time < MonthEnds)
                .Select(p => new { p.Time })
                .ToList();
            VisitCountDto visitPerHour = new VisitCountDto()
            {
                Display = new string[24],
                Value = new int[24],
            };


            for (int i = 0; i <= countDay; i++)
            {
                var currentday = DateTime.Now.AddDays(i * (-1));
                var queryDay = Month_PageViewList.Where(p => p.Time.Date == currentday.Date).AsQueryable();
                for (int j = 0; j <= 23; j++)
                {
                    visitPerHour.Display[j] = $"h-{j}";
                    visitPerHour.Value[j] += queryDay.Where(p => p.Time.Hour == j).Count();
                }


            }

            return visitPerHour;
        }
        private VisitCountDto GTetVisitPerHour(DateTime start, DateTime end)
        {
            var TodayPageViewList = _dbContext.Visitors.AsQueryable().Where(
              p => p.Time >= start && p.Time < end)
                .Select(p => new { p.Time }).ToList();

            VisitCountDto visitPerHour = new VisitCountDto()
            {
                Display = new string[24],
                Value = new int[24],
            };

            for (int i = 0; i <= 23; i++)
            {
                visitPerHour.Display[i] = $"h-{i}";
                visitPerHour.Value[i] = TodayPageViewList.Where(p => p.Time.Hour == i).Count();
            }

            return visitPerHour;
        }
        private VisitCountDto GetVisitPerDay()
        {
            DateTime start = DateTime.Now.Date;
            DateTime end = DateTime.Now.AddDays(1);
            TimeSpan ts = new TimeSpan(00, 00, 0);
            end = end.Date + ts;
            DateTime MonthStart = DateTime.Now.Date.AddDays(-30);
            DateTime MonthEnds = DateTime.Now.Date.AddDays(1);
            var Month_PageViewList = _dbContext.Visitors.AsQueryable()
                .Where(p => p.Time >= MonthStart && p.Time < MonthEnds)
                .Select(p => new { p.Time })
                .ToList();
            VisitCountDto visitPerDay = new VisitCountDto() { Display = new string[31], Value = new int[31] };
            //بازدید های 5 روز قبل
            VisitCountDto FiveDayEgovisitPerHour = GTetVisitPerHour(start.AddDays(-5), end.AddDays(-5));

            for (int i = 0; i <= 30; i++)
            {
                var currentday = DateTime.Now.AddDays(i * (-1));
                visitPerDay.Display[i] = i.ToString();
                visitPerDay.Value[i] = Month_PageViewList.Where(p => p.Time.Date == currentday.Date).Count();
            }

            return visitPerDay;
        }
    
        private List<MostVisitPostDto> MostVisitPostByDate(DateTime start, DateTime end, int count)
        {
            var visitorToday = _dbContext.Visitors.AsQueryable()
           .Where(p => p.Time >= start && p.Time < end).ToList();

            var VisitedPostReport = visitorToday.GroupBy(p => p.CurrentLink)
                    .Select(s => new MostVisitPostDto
                    {
                        CurrentLink = HttpUtility.UrlDecode(s.Key),
                        visited = s.Count(),
                        UniqeIpVisited = s.GroupBy(p => p.VisitorId).Count()
                    }).OrderByDescending(p => p.visited).Take(count).ToList();

            return VisitedPostReport;
        }
        private float GetAvg(long VisitPage, long Visitor)
        {
            if (Visitor == 0)
            {
                return 0;
            }
            else
            {
                return VisitPage / Visitor;
            }
        }
    }

    public class ResultTodayReportDto
    {
        public GeneralStatsDto GeneralStats { get; set; }
        public TodayDto Today { get; set; }
        public TodayDto YesterDayVisit { get; set; }
        public TodayDto TwoDayEgoVisit { get; set; }

        public TodayDto ThreeDayEgoVisit { get; set; }
        public TodayDto FourDayEgoVisit { get; set; }

        public TodayDto FiveDayEgoVisit { get; set; }

        public List<VisitorsDto> visitors { get; set; }
        public List<MostVisitPostDto> TodayMostVisitedLink { get; set; }
        public List<MostVisitPostDto> YesterdayMostVisitedLink { get; set; }
    }

    public class GeneralStatsDto
    {
        public long TotalPageViews { get; set; }
        public long TotalVisitors { get; set; }
        public float PageViewsPerVisit { get; set; }

        public VisitCountDto VisitPerDay { get; set; }
        public VisitCountDto VisitHourPerDayes { get; set; }
    }

    public class TodayDto
    {
        public long PageViews { get; set; }
        public long Visitors { get; set; }
        public float ViewsPerVisitor { get; set; }
        public VisitCountDto VisitPerhour { get; set; }
    }
    public class VisitCountDto
    {
        public string[] Display { get; set; }
        public int[] Value { get; set; }

    }

    public class VisitorsDto
    {
        public long Id { get; set; }
        public string Ip { get; set; }
        public string CurrentLink { get; set; }
        public string ReferrerLink { get; set; }
        public string Browser { get; set; }
        public string OperationSystem { get; set; }
        public bool IsSpider { get; set; }
        public DateTime Time { get; set; }
        public string VisitorId { get; set; }

    }
    public class MostVisitPostDto
    {
        public string CurrentLink { get; set; }
        public long visited { get; set; }
        public long UniqeIpVisited { get; set; } = 0;
    }

}
