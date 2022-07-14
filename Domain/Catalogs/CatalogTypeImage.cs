using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Catalogs
{
   public class CatalogTypeImage
    {
        public int Id { get; set; }
        public string Src { get; set; }
        public int CatalogTypeId { get; set; }
        public CatalogType CatalogType { get; set; }
    }
}
