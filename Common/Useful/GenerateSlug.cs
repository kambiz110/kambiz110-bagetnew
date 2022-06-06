using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Common.Useful
{
    public static class GenerateSlug
    {
        public static string GenerateSeoFriendlyUrlSlug(this string Title)
        {
            string phrase = string.Format("{0}", Title).Trim();

            string str = RemoveAccent(phrase).ToLower();
            // invalid chars           
            str = Regex.Replace(str, @"[^(\u0621-\u064A\u0660-\u0669\sa-zA-Z0-9ی)]+$", "");
            str = RemoveDenjerCharecter(str).ToLower();

            // convert multiple spaces into one space   
            str = Regex.Replace(str, @"\s", "-"); // hyphens 
                                                  // cut and trim 
                                                  // str = str.Substring(0, str.Length <= count ? str.Length : count).Trim();

            return str;
        }
        private static string RemoveAccent(string text)
        {

            byte[] bytes = Encoding.Default.GetBytes(text);
            text = Encoding.UTF8.GetString(bytes);

            return text;
        }
        public static string RemoveDenjerCharecter(string Title)
        {


            Title = Title.Replace(" - ", "-");
            Title = Title.Replace("- ", "-");
            Title = Title.Replace(" -", "-");
            Title = Title.Replace("    ", "-");
            Title = Title.Replace("   ", "-");
            Title = Title.Replace("  ", "-");
            Title = Title.Replace(" ", "-");
            Title = Title.Replace(".", "-");
            Title = Title.Replace("«", "-");
            Title = Title.Replace("»", "-");
            Title = Title.Replace("(", "-");
            Title = Title.Replace(")", "-");
            Title = Title.Replace("/", "");
            Title = Title.Replace("&", "");
            Title = Title.Replace("@", "");
            Title = Title.Replace("=", "");
            Title = Title.Replace("+", "");
            Title = Title.Replace("!", "");
            Title = Title.Replace("#", "");
            Title = Title.Replace("$", "");
            Title = Title.Replace("^", "");
            Title = Title.Replace("*", "");
            Title = Title.Replace(">", "");
            Title = Title.Replace("<", "");

            return Title;
        }
    }
}

