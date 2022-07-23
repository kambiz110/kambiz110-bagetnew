using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Discounts.Dto
{
   public class GetDiscountInHomePageViewModel
    {


        public int DiscountPercentage { get; set; } = 0;

        public DateTime? EndDate { get; set; }

        public int Id { get; set; }
        public string Name { get; set; }
        public List<catalogitemDtoForHomePage> catalogItems { get; set; }
    }
    public class catalogitemDtoForHomePage
    {
        public int Id { get; set; }
        public string CarName { get; set; }
        public string BrandName { get; set; }
        public string Name { get; set; }
        public string Src { get; set; }
        public int Price { get; set; }
        public int Rate { get; set; }
        public int? OldPrice { get; set; }
        public string Description { get; set; }
    }
}
