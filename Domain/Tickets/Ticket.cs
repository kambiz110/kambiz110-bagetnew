using Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Tickets
{
   public class Ticket
    {
        public long Id { get; set; }
        public string UserId { get; set; }
        public string AnswerUserId { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public string PhoneNumber { get; set; }
        public string Answer { get; set; }
        public bool IsActive { get; set; } = false;
        public string Ip { get; set; }
        public DateTime AtInserted { get; set; } = DateTime.Now;
        public DateTime AtAnswerDate { get; set; }
        public DateTime? Removed { get; set; }
        public bool? IsRemove { get; set; } = false;
    }
}
