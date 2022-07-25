using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Catalogs.CatalogTypes.Dto
{
  public  class CatalogItemShortPLP
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Slug { get; set; }
        public int DiscountPercentage { get; set; }
        public string Description { get; set; }
        public int? OldPrice { get; set; }
        public List<string> Images { get; set; }
        public byte Rate { get; set; }
        public int AvailableStock { get; set; }

        public string CarName { get; set; }
        public string BrandName { get; set; }
    }
}
