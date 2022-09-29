using Domain.Logs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Logs.Dto
{
    public class AddUserLogDto
    {
        public string StrKeyTable { get; set; }
        public string userName { get; set; }
        public logEvent userEvent { get; set; }
    }
}
