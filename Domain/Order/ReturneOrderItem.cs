using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Order
{
   public class ReturneOrderItem
    {
        public int Id { get; set; }
        public int ReturnedId { get; set; }
        public OrderItem OrderItem { get; set; }
        public int OrderItemId { get; set; }
        public DateTime InsertTime { get; set; } = DateTime.Now;
        public DateTime UpdateTime { get; set; } = DateTime.Now;
        public ReturneOrderItemStatus ItemStatus { get; set; }
    }
    public enum ReturneOrderItemStatus
    {

        /// <summary>
        /// در انتظار تحویل محصول به پست برای مرجوع شدن
        /// </summary>
        Processing = 0,

        /// <summary>
        /// سالم دریافت شد
        /// </summary>
        IntactDelivered =1,
        /// <summary>
        /// محصول صده دیده دریافت شد
        /// </summary>
        UnIntactDelivered = 2,
        /// <summary>
        /// محصول تعویض شده دریافت شد 
        /// </summary>
        ReplacedDelivered = 3,
        /// <summary>
        /// محصول سالم بود و مبلغ به مشتری بازگشت شد 
        /// </summary>
        ReturnPaymentInvoice = 4,
        /// <summary>
        /// تحویل پست گردید 
        /// </summary>
        PostGivedOrderItem =5,

    }
}
