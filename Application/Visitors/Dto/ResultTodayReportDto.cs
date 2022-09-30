using Application.Visitors.GetTodayReport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Visitors.Dto
{
    public class ResultTodayReportDto
    {
        public GeneralStatsDto GeneralStats { get; set; }
        public TodayDto Today { get; set; }
        public List<VisitorsDto> visitors { get; set; }

        public VisitCountDto VisitPerDay { get; set; }
        public VisitCountDto VisitHourPerDayes { get; set; }
    }
}
