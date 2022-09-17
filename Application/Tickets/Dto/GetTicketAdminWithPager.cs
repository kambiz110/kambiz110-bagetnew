using Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Tickets.Dto
{
  public class GetTicketAdminWithPager
    {
        public PagerDto PagerDto { get; set; }

        public List<GetAdminTicketDto> Tickets { get; set; }
    }
}
