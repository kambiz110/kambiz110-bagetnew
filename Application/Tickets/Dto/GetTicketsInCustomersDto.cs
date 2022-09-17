using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Tickets.Dto
{
   public class GetTicketsInCustomersDto
    {

        public string Title { get; set; }
        public string Comment { get; set; }
        public string PhoneNumber { get; set; }
        public string Answer { get; set; }
        public string AnswerUserName { get; set; }
        public DateTime AtInserted { get; set; }
        public DateTime AtAnswerDate { get; set; }
    }
}
