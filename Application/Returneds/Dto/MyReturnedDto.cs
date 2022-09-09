using Domain.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Returneds.Dto
{
   public class MyReturnedDto
    {
        public int ReturnedId { get; set; }
        public int OrderId { get; set; }
        public DateTime Date { get; set; }
        public int Price { get; set; }
        public int countOrderItems { get; set; } = 0;
        public ReturnedStatus ReturnedStatus { get; set; }

    }
}
