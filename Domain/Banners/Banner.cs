using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Banners
{
    public class Banner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Link { get; set; }
        public bool IsActive { get; set; }
        public int Priority { get; set; }
        public Position Position { get; set; }

    }

    public enum Position
    {
        /// <summary>
        /// اسلایدر
        /// </summary>
        [Display(Name = "اسلایدر بالای صفحه")]
        Slider = 0,
        /// <summary>
        /// سطر اول
        /// </summary>
        [Display(Name = "بنر میانه سطر اول")]
        single_banner1 = 1,
        /// <summary>
        /// سطر دوم
        /// </summary>    
        [Display(Name = "بنر میانه سطر دوم")]
        single_banner2 = 2,
        /// <summary>
        /// سطر سوم
        /// </summary>    
        [Display(Name = "بنر میانه سطر سوم")]
        single_banner3 = 3,
        /// <summary>
        /// بنر کنار صفحه 
        /// </summary>
        [Display(Name = "بنر کنار صفحه")]
        sidebar_banner = 4,
        /// <summary>
        /// بنر کنار تبلیغاتی
        /// </summary>
        [Display(Name = "بنر کنار تبلیغاتی")]
        sidebar_banner_ADs = 5,

        /// <summary>
        /// بنر  انتهای صفحه
        /// </summary>
        [Display(Name = "بنر  انتهای صفحه")]
        single_banner_Footer = 6,

       
  

    }

}
