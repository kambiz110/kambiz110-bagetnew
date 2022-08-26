using Domain.Postals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.PostalProducts.Dto
{
   public class AddPostalProductDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string TrackingNumber { get; set; }
        public PostalType PostalType { get; set; }
        public PostalStatus PostalStatus { get; set; }
        public int OrderId { get; set; }
        public string PostOfficeName { get; set; }
        public DateTime? InsertDate { get; set; }
    }
}
