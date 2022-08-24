using Domain.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Domain.Payments
{
    [Auditable]
    public class Payment
    {
        public Guid Id { get; set; }
        public int Amount { get; private set; }
        public bool IsPay { get; private set; } = false;
        public DateTime? DatePay { get; private set; } = null;
        public string Authority { get; private set; }
        public long RefId { get; private set; } = 0;
        public Order.Order Order { get; private set; }
        public int OrderId { get; private set; }

        public PaymentStatus PaymentStatus { get; private set; }
        public Payment(int amount, int orderId)
        {
            Amount = amount;
            OrderId = orderId;
            PaymentWaitingForPayment();
        }

        public void PaymentIsDone(string authority, long refId)
        {
            IsPay = true;
            DatePay = DateTime.Now;
            Authority = authority;
            RefId = refId;
        }
        /// <summary>
        /// پرداخت انجام شد
        /// </summary>
        public void PaymentDone()
        {
            PaymentStatus = PaymentStatus.Paid;
        }
        /// <summary>
        /// پرداخت لغو شد
        /// </summary>
        public void PaymentCanceled()
        {
            PaymentStatus = PaymentStatus.Canceled;
        }
        /// <summary>
        /// منتظر پرداخت
        /// </summary>
        public void PaymentWaitingForPayment()
        {
            PaymentStatus = PaymentStatus.WaitingForPayment;
        }
    }
    public enum PaymentStatus
    {
        /// <summary>
        /// منتظر پرداخت
        /// </summary>
        WaitingForPayment = 0,
        /// <summary>
        /// پرداخت انجام شد
        /// </summary>
        Paid = 1,
        /// <summary>
        /// پرداخت لغو شد
        /// </summary>
        Canceled = 2,
    }
}
