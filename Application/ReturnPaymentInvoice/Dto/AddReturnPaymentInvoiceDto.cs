using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ReturnPaymentInvoice.Dto
{
   public class AddReturnPaymentInvoiceDto
    {
        public int Amount { get; private set; }
        public DateTime DatePay { get; set; }
        public string FollowKey { get; set; }
        public string BankOriginNumber { get; set; }
        public string BankOrigin { get; set; }
        public string BankDestination { get; set; }
        public string BankDestinationNumber { get; set; }
        public int ReturnedId { get; set; }
    }
}
