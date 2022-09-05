using Domain.Postals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Order
{
   public class Returned
    {
        public int Id { get; set; }
        public Order Order { get; set; }
        public int OrderId { get; set; }
        public ICollection<ReturneOrderItem> ReturneOrderItems { get; set; }
        public DateTime InsertTime { get; set; } = DateTime.Now;
        public DateTime UpdateTime { get; set; } = DateTime.Now;
    }
}
