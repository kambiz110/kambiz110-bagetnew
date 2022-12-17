using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Orders.Dto
{
   public class SaleReportDto
    {
        [Display(Name = " تاریخ شروع ")]
        public DateTime? StartDate { get; set; } = null;
        [Display(Name = " تاریخ پایان ")]
        public DateTime? EndDate { get; set; } = null;
        [Display(Name = " دوره زمانی ")]
        public int period { get; set; } = 0;
    }
}
