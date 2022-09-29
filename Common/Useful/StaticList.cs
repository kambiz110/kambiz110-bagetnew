using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Useful
{
    public static class StaticList
    {
        public static List<KeyValuePair<string, int>> UserLogListKeyValuePair = new List<KeyValuePair<string, int>>() {
            new KeyValuePair<string, int>("خروج", 0),
            new KeyValuePair<string, int>("ورود", 1),
            new KeyValuePair<string, int>("ویرایش تیکت", 2),
            new KeyValuePair<string, int>("افزودن محصول", 3),
            new KeyValuePair<string, int>(" ویرایش محصول", 4),
            new KeyValuePair<string, int>("ارسال مرجوعی", 5),
            new KeyValuePair<string, int>("ارسال محصول", 6),
            new KeyValuePair<string, int>(" بازگشت وجه به کاربر", 7),
            new KeyValuePair<string, int>(" کنسل کردن مرجوعی مشتری", 8),
            new KeyValuePair<string, int>(" جواب کامنت", 9),
            new KeyValuePair<string, int>(" ویرایش کامنت", 10),
            new KeyValuePair<string, int>(" انتشار کامنت", 11),
            new KeyValuePair<string, int>("حذف کامنت", 12),
            new KeyValuePair<string, int>(" جواب تیکت", 13),
            new KeyValuePair<string, int>(" افزودن تخفیف", 14),
            new KeyValuePair<string, int>(" ویرایش تخفیف", 15),
            new KeyValuePair<string, int>(" افزودن دسته بندی", 16),
            new KeyValuePair<string, int>(" ویرایش دسته بندی", 17),
             new KeyValuePair<string, int>("افزودن موجودی به انبار", 18),
            new KeyValuePair<string, int>(" دریافت محصول توسط مشتری", 19),
            new KeyValuePair<string, int>(" دریافت محصول در فروشگاه", 20),
        };
    }
}
