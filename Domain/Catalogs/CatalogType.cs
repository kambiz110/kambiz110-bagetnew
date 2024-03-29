﻿using Domain.Attributes;
using Domain.Blogs;
using System.Collections.Generic;

namespace Domain.Catalogs
{
    [Auditable]
    public class CatalogType
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int SortIndex { get; set; }
        public virtual CatalogTypeImage CatalogTypeImage { get; set; }
        public int? ParentCatalogTypeId { get; set; }
        public CatalogType ParentCatalogType { get; set; }

        public ICollection<CatalogType> SubType { get; set; }
        public ICollection<CatalogItem> CatalogItems { get; set; }
        public ICollection<Blog> Blogs { get; set; }
    }
}
