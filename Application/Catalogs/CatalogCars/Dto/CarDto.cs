using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Catalogs.CatalogCars.Dto
{
  
    public class CarDto
    {
        public int Id { get; set; }
        [Display(Name = "نام خودرو")]
        public string Name { get; set; }
        [Display(Name = "مسیر عکس ")]
        public string Src { get; set; }

        [Display(Name = "خودرو داخلی است ؟ ")]
        public bool IsDakely { get; set; }

    }
    public class CarListDto
    {
        public int Id { get; set; }

        [Display(Name = "نام خودرو")]
        public string Name { get; set; }
        [Display(Name = "مسیر عکس ")]
        public string Src { get; set; }

        [Display(Name = "خودرو داخلی است ؟ ")]
        public bool IsDakely { get; set; }
    }
}
