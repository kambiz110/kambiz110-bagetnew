using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Postals
{
   public class ReturnedProduct
    {
        public int Id { get; set; }
        public PostalCompany PostalCompane { get; set; }
        public string TrackingNumber { get; set; }
        public PostalStatus PostalStatus { get; set; }
        public Order.Returned Returned { get; set; }
        public int ReturnedId { get; set; }
        public string PostOfficeName { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime? ReciveDate { get; set; }
    }
}
