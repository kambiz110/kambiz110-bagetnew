using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Discounts.Dto
{
   public class GetDescountsForEditViewModel
    {
        public int Id { get; set; }
        [Display(Name = "نام تخفیف")]
        public string Name { get; set; }
        [Display(Name = "استفاده از درصد؟")]
        public bool UsePercentage { get; set; } = false;
        [Display(Name = "درصد تخفیف")]
        public int DiscountPercentage { get; set; } = 0;
        [Display(Name = "مبلغ تخفیف")]
        public int DiscountAmount { get; set; } = 0;
        [Display(Name = "زمان شروع")]
        public DateTime? StartDate { get; set; }
        [Display(Name = "زمان انقضا")]
        public DateTime? EndDate { get; set; }
        [Display(Name = "استفاده از کوپن")]
        public bool RequiresCouponCode { get; set; }
        [Display(Name = "کد کوپن")]
        public string CouponCode { get; set; }
        [Display(Name = "نوع تخفیف")]
        public int DiscountTypeId { get; set; }
        [Display(Name = "محدودیت تخفیف")]
        public int DiscountLimitationId { get; set; }
        [Display(Name = "اهمیت در صفحه")]
        public int Importance { get; set; }

        [Display(Name = "تعداد کد تخفیف")]
        public int LimitationTimes { get; set; } = 0;

        public int Width { get; set; }
        public int Height { get; set; }
        public int Length { get; set; }
        public int Weight { get; set; }
        public List<int> appliedToCatalogItem { get; set; }

        public List<catalogitemDtoForEditDescount> catalogItems { get; set; }
    }
    public class catalogitemDtoForEditDescount
    {
        public int Id { get; set; }
        public string CarName { get; set; }
        public string BrandName { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

    }
}
