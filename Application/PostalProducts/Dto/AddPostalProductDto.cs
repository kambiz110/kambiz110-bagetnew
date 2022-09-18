using Domain.Postals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.PostalProducts.Dto
{
   public class AddPostalProductDto
    {
        public int Id { get; set; }
        public string TrackingNumber { get; set; }
        public PostalType PostalType { get; set; }
        public PostalStatus PostalStatus { get; set; }
        public PostalCompany PostalCompane { get; set; }
        public int OrderId { get; set; }
        public string PostOfficeName { get; set; }
        public DateTime? InsertDate { get; set; }
    }
    public class AddReturnedPostalProductDto
    {
        public int Id { get; set; }
        public string TrackingNumber { get; set; }
        public PostalType PostalType { get; set; }
        public PostalStatus PostalStatus { get; set; }
        public PostalCompany PostalCompane { get; set; }
        public int ReturnedId { get; set; }
        public string PostOfficeName { get; set; }
        public DateTime? InsertDate { get; set; }
    }
    
    public class ResiveOrderItemsReturnedDto
    {
         public int ReturnedId { get; set; }
        public List<OrderItemsReturnedDto> OrderItemsReturnedDtos { get; set; }
    }
    public class OrderItemsReturnedDto {
      public int Id { get; set; }
        public int ReturneOrderItemStatus { get; set; }
        
                   
    }
    public enum PostalCompany
    {
        /// <summary>
        /// الوپیک
        /// </summary>
        alopeyk = 1,
        /// <summary>
        ///  تیپاکس
        /// </summary>
        tipax = 2,
        /// <summary>
        ///  پست ایران
        /// </summary>
        post_ir = 3,

        /// <summary>
        ///  اسنپ باکس
        /// </summary>
        Snap_Box = 4,
        /// <summary>
        ///  اسنپ بار
        /// </summary>
        Snap_Bar = 5,


    }
}
