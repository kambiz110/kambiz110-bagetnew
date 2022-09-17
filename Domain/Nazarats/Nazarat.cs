using Domain.Catalogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Nazarats
{
   public class Nazarat
    {
        public long Id { get; set; }
        public CatalogItem CatalogItem { get; set; }
        public int CatalogItemId { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public bool IsActive { get; set; } = false;
        public string Ip { get; set; }
        public DateTime AtInserted { get; set; }
        public DateTime? Removed { get; set; }
        public bool? IsRemove { get; set; } = false;
    }
}
