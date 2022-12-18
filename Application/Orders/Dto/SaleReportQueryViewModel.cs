using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Orders.Dto
{
    public class FerstSaleReportQueryViewModel
    {
        public BuyDto Today { get; set; }
        public BuyDto YesterDay { get; set; }
        public BuyDto NowWeek { get; set; }
        public BuyDto LastWeek { get; set; }
        public BuyDto NowMonthd { get; set; }
        public BuyDto LastMonthd { get; set; }
    }
    public class ReportQueryViewModel
    {
        public BuyReportCountDto Statistics { get; set; }
        public BuyDto Buyers { get; set; }
    }
    public class BuyReportCountDto
    {
        public string[] Display { get; set; }
        public int[] Value { get; set; }

    }
    public class BuyDto
    {
        public int Buyers { get; set; }
        public int BuyCount { get; set; }
        public BuyReportCountDto SaleReport { get; set; }
    }
}
