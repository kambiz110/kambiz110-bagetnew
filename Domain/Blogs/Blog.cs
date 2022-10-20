using Domain.Catalogs;
using Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Blogs
{
   public class Blog
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Introtext { get; set; }
        public string Fulltext { get; set; }
        public byte Status { get; set; } = 0;
        public string Tageees { get; set; }
        public int CatalogTypeId { get; set; }
        public CatalogType CatalogType { get; set; }
        public int CatologCarId { get; set; }
        public CatologCar CatologCar { get; set; }
        public DateTime Created { get; set; }
        public DateTime modified { get; set; }
        public DateTime LastVisit { get; set; }
        public DateTime? Publish_up { get; set; }
        public DateTime? Publish_down { get; set; }
        public string UserCreatedById { get; set; }
        public string Image { get; set; }
    }
}
