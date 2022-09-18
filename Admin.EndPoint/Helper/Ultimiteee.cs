using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.EndPoint.Helper
{
    public static class Ultimiteee
    {


        public static DateTime ToPersianDate(this DateTime dt)
        {
            PersianCalendar pc = new PersianCalendar();
            int year = pc.GetYear(dt);
            int month = pc.GetMonth(dt);
            int day = pc.GetDayOfMonth(dt);


            return new DateTime(year, month, day);
        }
        public static string ToPersianDateString(this DateTime dtt)
        {
            PersianCalendar pc = new PersianCalendar();
            int year = pc.GetYear(dtt);
            int month = pc.GetMonth(dtt);
            int day = pc.GetDayOfMonth(dtt);
            var dt = String.Format("{0}/{1}/{2}", year, month, day);


            return dt;
        }
        public static string ToPersianDateStrFarsi(this DateTime? dtt)
        {
            PersianCalendar pc = new PersianCalendar();
            int year = pc.GetYear((DateTime)dtt);
            int month = pc.GetMonth((DateTime)dtt);
            int day = pc.GetDayOfMonth((DateTime)dtt);
            string FarsiMonth = FarsiMonthLtr[month].ToString();
            var dtFarsi = String.Format(" {0} {1} {2} ", day, FarsiMonth, year);


            return dtFarsi;
        }
        public static string ToPersianDateStrFarsi(this DateTime dtt)
        {
            PersianCalendar pc = new PersianCalendar();
            int year = pc.GetYear((DateTime)dtt);
            int month = pc.GetMonth((DateTime)dtt);
            int day = pc.GetDayOfMonth((DateTime)dtt);
            string FarsiMonth = FarsiMonthLtr[month].ToString();
            var dtFarsi = String.Format(" {0} {1} {2} ", day, FarsiMonth, year);


            return dtFarsi;
        }
        public static string ToPersianDateStrFarsiFull(this DateTime dtt)
        {
            if (dtt == null)
            {
                return "";
            }
            PersianCalendar pc = new PersianCalendar();
            int year = pc.GetYear(dtt);
            int month = pc.GetMonth(dtt);
            int day = pc.GetDayOfMonth(dtt);
            int hour = pc.GetHour(dtt);
            int min = pc.GetMinute(dtt);
            string FarsiMonth = FarsiMonthLtr[month].ToString();
            var dtFarsi = String.Format(" {0} {1} {2} ساعت {3} : {4}", day, FarsiMonth, year, min, hour);


            return dtFarsi;
        }
        public static DateTime ToPersianDateRtl(this DateTime dt)
        {
            PersianCalendar pc = new PersianCalendar();
            int year = pc.GetYear(dt);
            int month = pc.GetMonth(dt);
            int day = pc.GetDayOfMonth(dt);


            return new DateTime(day, month, year);
        }
        public static DateTime ToPersianDateTime(this DateTime dt)
        {
            PersianCalendar pc = new PersianCalendar();
            int year = pc.GetYear(dt);
            int month = pc.GetMonth(dt);
            int day = pc.GetDayOfMonth(dt);
            int hour = pc.GetHour(dt);
            int min = pc.GetMinute(dt);

            return new DateTime(year, month, day, hour, min, 0);
        }

        public static DateTime ToDateConvertDateTime(this DateTime dt)
        {

            int year = dt.Year;
            int month = dt.Month;
            int day = dt.Day;


            return new DateTime(year, month, day);
        }

        public static bool TwoDateEqules(this DateTime dt1, DateTime dt2)
        {
            int year1 = dt1.Year;
            int month1 = dt1.Month;
            int day1 = dt1.Day;
            ///*****************
            int year2 = dt2.Year;
            int month2 = dt2.Month;
            int day2 = dt2.Day;

            if (year1 == year2 && month1 == month2 && day1 == day2)
            {
                return true;
            }

            return false;
        }
        public static DateTime ToMiladiDate(this DateTime dt)
        {
            PersianCalendar pc = new PersianCalendar();
            return pc.ToDateTime(dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, 0, 0);
        }
        public static DateTime ToSplitMiladiDate(this string dt)
        {
            string[] sList1 = dt.Split(' ');
            string[] sList = sList1[0].Split('/');
            int Year = Int32.Parse(sList[2]);
            int Month = Int32.Parse(sList[0]);
            int Day = Int32.Parse(sList[1]);

            var result = new DateTime(Year, Month, Day, 12, 0, 0, 0);
            return result;
        }
        public static string[] FarsiMonthLtr = new[] { "", "فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی", "بهمن", "اسفند" };
        public static string[] FarsiMonthRtl = new[] { "فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی", "بهمن", "اسفند", "" };
        public static string[] MiladiMonth = new[] { "", "January", "February", "February", "April", "May", "May", "July", "September", "October", "November", "December", "January" };
        //DateTimeFormat.AbbreviatedMonthNames = new[] { "فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی", "بهمن", "اسفند", "" };
        //DateTimeFormat.AbbreviatedMonthGenitiveNames = new[] { "فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی", "بهمن", "اسفند", "" };


        //DateTimeFormat.AbbreviatedDayNames = new string[] { "ی", "د", "س", "چ", "پ", "ج", "ش" };
        //DateTimeFormat.ShortestDayNames = new string[] { "ی", "د", "س", "چ", "پ", "ج", "ش" };
        //DateTimeFormat.DayNames = new string[] { "یکشنبه", "دوشنبه", "ﺳﻪشنبه", "چهارشنبه", "پنجشنبه", "جمعه", "شنبه" };

        //DateTimeFormat.AMDesignator = "ق.ظ";
        //DateTimeFormat.PMDesignator = "ب.ظ";


        //DateTimeFormat.ShortDatePattern = "yyyy/MM/dd";
        //DateTimeFormat.LongDatePattern = "yyyy/MM/dd";

        //DateTimeFormat.SetAllDateTimePatterns(new[] { "yyyy/MM/dd" }, 'd');
        //DateTimeFormat.SetAllDateTimePatterns(new[] { "dddd, dd MMMM yyyy" }, 'D');
        //DateTimeFormat.SetAllDateTimePatterns(new[] { "yyyy MMMM" }, 'y');
        //DateTimeFormat.SetAllDateTimePatterns(new[] { "yyyy MMMM" }, 'Y');
        public static string ToContentType(this int CountentType)
        {
            string result = "";
            switch (CountentType)
            {
                case 0:
                    result = "عکس";
                    break;
                case 1:
                    result = "نماهنگ";
                    break;
                case 2:
                    result = "آوا";
                    break;
                default:
                    break;
            }
            return result;
        }
        public static string ToFarsiRole(this string role)
        {
            string result = "";
            switch (role)
            {
                case "Admin":
                    result = "مدیر سایت";
                    break;
                case "Maneger":
                    result = "مدیر گروه";
                    break;
                case "homophony":
                    result = "عضو گروه هم نوایی";
                    break;
                case "Editor":
                    result = "تدوین گر";
                    break;
                case "Cameraman":
                    result = "فیلم بردار";
                    break;
                case "Sound_recordist":
                    result = "صدا بردار";
                    break;
                default:
                    break;
            }
            return result;
        }
        public static IList<string> ToArryTag(this string tages)
        {
            IList<string> names = tages.Split(',').Reverse().ToList<string>();
            if (names.Count() > 0)
            {

                for (int i = 0; i < names.Count(); i++)
                {
                    names[i] = names[i].Trim().Replace(" ", "_");
                }

            }
            return names;
        }

        public static string ArryTagToString(this IList<string> tages)
        {
            string result = "";
            if (tages.Count() > 0)
            {

                for (int i = 0; i < tages.Count(); i++)
                {
                    result = result + tages[i].Trim() + ",";
                }

            }
            result = result.Remove(result.Length - 1);
            return result;
        }

        public static string ToCuteTitleWithCounter(this string title, int count)
        {
            if (title != null)
            {
                var lenght = title.Length;
                if (count < lenght)
                {
                    title = title.Remove(count);
                    title += "...";
                }
            }


            return title;
        }
    }
}
