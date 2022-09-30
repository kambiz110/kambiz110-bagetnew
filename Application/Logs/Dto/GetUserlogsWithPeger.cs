using Application.Dtos;
using Application.Logs.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Logs.Query
{
  public  class GetUserlogsWithPeger
    {
        public PagerDto PagerDto { get; set; }

        public List<GetUserLogDto> UserLogs { get; set; }
    }
}
