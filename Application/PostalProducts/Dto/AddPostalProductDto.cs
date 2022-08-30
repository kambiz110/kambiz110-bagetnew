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


    }
}
