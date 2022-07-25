using Domain.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Catalogs
{
    [Auditable]
    public class CatalogBrand
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public bool IsDakely { get; set; }
        public string Src { get; set; } = "Resources/images/Static/Default.jpg";
    }
}
