using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Catalogs.CatalogFeature.Dto
{
  public  class RemoveFeatureDto
    {
        public int itemid { get; set; }
        public string Group { get; set; }

        public string Key { get; set; }

        public string Value { get; set; }
    }
}
