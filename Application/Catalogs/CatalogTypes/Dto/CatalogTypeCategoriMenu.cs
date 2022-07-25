using Domain.Catalogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Catalogs.CatalogTypes.Dto
{
   public class CatalogTypeCategoriMenu
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int SortIndex { get; set; }
        public int? ParentCatalogTypeId { get; set; }
        public ICollection<CatalogType> SubType { get; set; }
    }
}
