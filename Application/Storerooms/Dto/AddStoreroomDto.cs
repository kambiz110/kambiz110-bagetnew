using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Storerooms.Dto
{
  public  class AddStoreroomDto
    {
        public int Id { get; set; }
        public int StockCount { get; set; }
        public int CatalogItemId { get; set; }
        public string UserId { get;  set; }
    }
}
