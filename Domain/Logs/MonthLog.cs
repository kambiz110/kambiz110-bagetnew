using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Logs
{
   public class MonthLog
    {
        public long Id { get; set; }
        public long CountLog { get; set; }
        public int yeaar { get; set; }
        public int Monthh { get; set; }

        public DateTime InsertTime { get; set; } = DateTime.Now;
        public DateTime UpdateTime { get; set; } = DateTime.Now;
    }
}
