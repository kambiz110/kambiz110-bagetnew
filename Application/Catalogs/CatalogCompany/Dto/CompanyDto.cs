using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Catalogs.CatalogCompany.Dto
{
  
    public class CompanyDto
    {
        public int Id { get; set; }
        [Display(Name = "نام کمپانی")]
        public string Name { get; set; }
        [Display(Name = "مسیر عکس ")]
        public string Src { get; set; }
        [Display(Name = "خودرو داخلی است ؟ ")]
        public bool IsDakely { get; set; }

    }
    public class CompanyListDto
    {
        public int Id { get; set; }

        [Display(Name = "نام کمپانی")]
        public string Name { get; set; }
        [Display(Name = "مسیر عکس ")]
        public string Src { get; set; }
        [Display(Name = "خودرو داخلی است ؟ ")]
        public bool IsDakely { get; set; }
    }
}
