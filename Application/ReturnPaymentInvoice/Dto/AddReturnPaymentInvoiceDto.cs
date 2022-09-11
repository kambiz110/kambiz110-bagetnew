using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ReturnPaymentInvoice.Dto
{
   public class AddReturnPaymentInvoiceDto
    {
        public int Amount { get;  set; }
        [Display(Name = "تاریخ و زمان واریز")]
        [Required(ErrorMessage = " {0}  را وارد نمائید ")]
        public DateTime DatePay { get; set; }
        public string FollowKey { get; set; }
        public string BankOriginNumber { get; set; }
        public string BankOrigin { get; set; }
        [Display(Name = "نام بانک مقصد")]
        [Required(ErrorMessage = " {0}  را وارد نمائید ")]
        public string BankDestination { get; set; }
        [Display(Name = "شماره حساب بانک مقصد")]
        [Required(ErrorMessage = " {0}  را وارد نمائید ")]
        public string BankDestinationNumber { get; set; }
        public int ReturnedId { get; set; }
    }
    public class BankDitel
    {
        public string UserName { get; set; }
        public string BankOrigin { get; set; }
        public string BankOriginNumber { get; set; }
    }
}
