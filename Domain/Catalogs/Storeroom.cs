using Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Catalogs
{
   public class Storeroom
    {
        public int Id { get; set; }
        public int StockCount { get; set; }
        public int CatalogItemId { get; set; }
        public string UserId { get; set; }
        public CatalogItem CatalogItem { get; set; }
        public DateTime InsertTime { get; set; } = DateTime.Now;
    }
}
