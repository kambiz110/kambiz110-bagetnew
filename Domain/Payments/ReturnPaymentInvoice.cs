using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Payments
{
   public class ReturnPaymentInvoice
    {
        public Guid Id { get; set; }
        public int Amount { get; private set; }
        public DateTime DatePay { get;  set; }
        public string FollowKey { get; set; }
        public string BankOrigin { get; set; }
        public string BankDestination { get; set; }
        public Order.Order Order { get;  set; }
        public int OrderId { get;  set; }
        public ReturnPaymentStatus PaymentStatus { get;  set; }
    }
    public enum ReturnPaymentStatus
    {

        /// <summary>
        /// پرداخت مرجوعی 
        /// </summary>
        Returned = 1,
        /// <summary>
        /// پرداخت لغو 
        /// </summary>
        Canceled = 2,
    }
}
