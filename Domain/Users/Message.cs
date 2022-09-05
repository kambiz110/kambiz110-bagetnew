using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Users
{
   public class Message
    {
        public long Id { get; set; }
        public User User { get; set; }
        public string UserId { get; set; }
        public string TextMessage { get; set; }
        public bool Visited { get; set; } = false;
        public DateTime InsertTime { get; set; } = DateTime.Now;
        public DateTime? VisitedTime { get; set; }

    }
}
