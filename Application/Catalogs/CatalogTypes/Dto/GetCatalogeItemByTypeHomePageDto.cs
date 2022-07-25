using Application.Catalogs.CatalogItems.GetCatalogIItemPLP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Catalogs.CatalogTypes.Dto
{
   public class GetCatalogeItemByTypeHomePageDto
    {
        List<childCatalogeItemsByType> itemsByTypes { get; set; }
    }
    public class childCatalogeItemsByType
    {
        public string Name { get; set; }
        public List<CatalogPLPDto> catalogs { get; set; }
    }
}
