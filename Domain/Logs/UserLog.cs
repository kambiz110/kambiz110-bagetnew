using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Logs
{
   public class UserLog
    {
        public long Id { get; set; }
        public string StrKeyTable { get; set; }
        public string userName { get; set; }
        public logEvent userEvent { get; set; }
        public string Ip { get; set; }
        public DateTime InsertTime { get; set; } = DateTime.Now;
    }
    public enum logEvent
    {
        /// <summary>
        ///  ورود
        /// </summary>
        login = 1,
        /// <summary>
        ///   خروج
        /// </summary>
        logout = 0,
        /// <summary>
        ///  ویرایش تیکت
        /// </summary>
        editTicket = 2,
        /// <summary>
        ///  افزودن محصول
        /// </summary>
        addProduct = 3,
        /// <summary>
        ///   ویرایش محصول
        /// </summary>
        editProduct = 4,
        /// <summary>
        ///  ارسال مرجوعی
        /// </summary>
        sendReturned = 5,
        /// <summary>
        ///  ارسال محصول
        /// </summary>
        sendOrder = 6,

        /// <summary>
        ///   بازگشت وجه به کاربر
        /// </summary>
        ReturnPaymentInvoice = 7,
        /// <summary>
        ///   کنسل کردن مرجوعی مشتری
        /// </summary>
        CanselReturned = 8,
        /// <summary>
        ///  جواب کامنت
        /// </summary>
        answerComment =9,
        /// <summary>
        ///   ویرایش کامنت
        /// </summary>
        editComment = 10,
        /// <summary>
        ///  انتشار کامنت
        /// </summary>
        publishComment = 11,
        /// <summary>
        ///   حذف کامنت
        /// </summary>
        deletedComment = 12,

        /// <summary>
        ///  جواب تیکت
        /// </summary>
        answerTicket = 13,
        /// <summary>
        ///  افزودن تخفیف
        /// </summary>
        addDiscount = 14,
        /// <summary>
        ///   ویرایش تخفیف
        /// </summary>
        editDiscount = 15,
        /// <summary>
        ///    افزودن دسته بندی
        /// </summary>
        addCatalogType = 16,

        /// <summary>
        ///   ویرایش دسته بندی
        /// </summary>
        editCatalogType = 17,
        /// <summary>
        ///  افزودن موجودی به انبار
        /// </summary>
        addStoreroom = 18,
        /// <summary>
        ///  دریافت محصول توسط مشتری
        /// </summary>
        DeliveredOrder = 19,
        /// <summary>
        ///  دریافت محصول در فروشگاه
        /// </summary>
        DeliveredReturned = 20,


    }
}
