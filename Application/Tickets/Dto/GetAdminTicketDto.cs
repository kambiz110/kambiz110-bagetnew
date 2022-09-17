using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Tickets.Dto
{
   public class GetAdminTicketDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string UserId { get; set; }
        public string PhoneNumber { get; set; }
        public string FullName { get; set; }
        public string Comment { get; set; }
        public bool status { get; set; }
        public DateTime AtInserted { get; set; }

    }
}
