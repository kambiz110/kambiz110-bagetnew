using Domain.Logs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Logs.Dto
{
  public  class GetUserLogDto
    {
        public long Id { get; set; }
        public string StrKeyTable { get; set; }
        public string userName { get; set; }
        public logEvent userEvent { get; set; }
        public DateTime InsertTime { get; set; }
    }
}
