using Domain.Attributes;
using Domain.Blogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Catalogs
{
    [Auditable]
    public  class CatologCar
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDakely { get; set; }
        public string Src { get; set; } = "Resources/images/Static/Default.jpg";
        public ICollection<Blog> Blogs { get; set; }
    }
}
