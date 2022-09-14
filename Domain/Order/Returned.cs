using Domain.Payments;
using Domain.Postals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Order
{
   public class Returned
    {
        public int Id { get; set; }
        public Order Order { get; set; }
        public int OrderId { get; set; }
        public string UserId { get; set; }
        public ReturnPaymentInvoice ReturnPaymentInvoice { get; set; }
        public PostProduct PostProduct { get; set; }
        public ReturnedStatus ReturnedStatus { get; set; }
        public ICollection<ReturneOrderItem> ReturneOrderItems { get; set; }
        public DateTime InsertTime { get; set; } = DateTime.Now;
        public DateTime UpdateTime { get; set; } = DateTime.Now;
    }
    public enum ReturnedStatus
    {
        /// <summary>
        /// در حال پردازش
        /// </summary>
        Processing = 0,
        /// <summary>
        /// تحویل داده شد
        /// </summary>
        Returned = 1,
        /// <summary>
        ///تحویل مامور پست گردید 
        /// </summary>
        PostOfficalDelivered = 2,
        /// <summary>
        /// در حال پردازش
        /// </summary>
        Cancelled = 3,
        /// <summary>
        ///  مبلغ به مشتری بازگشت شد 
        /// </summary>
        ReturnPaymentInvoice = 4,
    }
}
