using Domain.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Catalogs
{
    [Auditable]
    public class CatalogCompany
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDakely { get; set; }
    }
}
