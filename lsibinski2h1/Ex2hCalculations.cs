using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using lsibinski2h1;

namespace lsibinski2h1
{
    public class Ex2hCalculations
    {
        public static string DateCalc06(string strYear, string strMonth, string strDay)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {
                int year = Int32.Parse(strYear);
                int month = Int32.Parse(strMonth);
                int day = Int32.Parse(strDay);
                date = new DateTime(year, month, day);
                result = date.ToShortDateString();
            }
            catch { }

            return result;
        }

        public static string DateCalc07(string strDate)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {
                date = DateTime.Parse(strDate);
                result = date.ToShortDateString();
            }
            catch { }

            return result;
        }

        public static string DateCalc08(string strDate)
        {
            string result = "Invalid input";
            DateTime date;
            DateTime.TryParse(strDate, out date);
            result = date.ToShortDateString();

            return result;
        }

        public static string DateCalc09(string strDate1, string strDate2)
        {
            string result = "Invalid input";
            DateTime date1;
            DateTime date2;
            try
            {
                date1 = DateTime.Parse(strDate1);
                date2 = DateTime.Parse(strDate2);
                TimeSpan date3 = date1 - date2;;
                result = date3.TotalDays.ToString() + " days";
            }
            catch { }

            return result;
        }

        public static string DateCalc10(string strDate1, string strDate2)
        {
            string result = "Invalid input";
            DateTime date1;
            DateTime date2;
            try
            {
                date1 = DateTime.Parse(strDate1);
                date2 = DateTime.Parse(strDate2);
                TimeSpan date3 = date1 - date2;
                if (date1 > date2)
                    result = date3.TotalDays.ToString() + " days past due";
                else if (date1 <= date2) 
                 result = "On time";
            }
            catch { }

            return result;
        }

        public static string StringCalc01(string s)
        { 
            string result = "Invalid input";
            s = s.Trim();
            try
            {
                s = s.Remove(0, 1);
                s = s.Insert(0, "cr");
                result = s.ToString();
            }
            catch { }

            return result;
        }

        public static string StringCalc02(string s)
        {
            string result = "Invalid input";
            s = s.Trim();
            try
            {
                s = s.Remove(1, 1);
                s = s.Insert(1, "rit");
                result = s.ToString();
            }
            catch { }

            return result;
        }

        public static string StringCalc03(string s)
        {
            string result = "Invalid input";
            s = s.Trim();
            try
            {
                s = s.Substring(2, 4).ToUpper();
                result = s.ToString();
            }
            catch { }

            return result;
        }

        public static string StringCalc04(string s)
        {
            string result = "Invalid input";
            s = s.Trim();
            try
            {
                s = s.PadLeft(10, '*');
                result = s.ToString();
            }
            catch { }

            return result;
        }

        public static string StringCalc05(string s)
        {
            string result = "Invalid input";
            s = s.Trim();
            try
            {
                s = s.Replace("(", "");
                s = s.Replace(")", "");
                s = s.Replace("-", "");
                s = s.Replace(" ", "");
                result = s.ToString();
            }
            catch { }

            return result;
        }

        public static string StringCalc06(string s)
        {
            s = s.Trim();
            s = s.Replace("(", "");
            s = s.Replace(")", "");
            s = s.Replace("-", "");
            s = s.Replace(" ", "");

            if (s.Length == 10)
            {
                s = s.Insert(3, ".");
                s = s.Insert(7, ".");
            }
            else if (s.Length == 7)
            {
                s = s.Insert(3, ".");
            }
            else if (s.Length <= 7)
                return "Invalid input";

            return s;
        }

        public static string StringCalc07(string s)
        {
            string s1 = "pioneer";
            s = s.Trim();

                s = s.Substring(0).ToLower();
                if (s.Contains(s1))
                {
                    s = "Found";
                }
                else
                    s = "Not found";

                s = s.ToString();
            
            return s;
        }

        public static string StringCalc08(string s)
        {
            s = s.Trim();
            if (s.Length > 9)
            {
                int i = s.IndexOf(", ");
                s = s.Substring(i + 2);
            }
            else
                return "Invalid input";

            return s;
        }

        public static string StringCalc09(string s)
        {
            s = s.Trim();
            if (s.Length > 10)
            { 
                int i = s.LastIndexOf(" ");
                s = s.Substring(i + 1);
            }
            else
                return "Invalid input";


            return s;
        }

        public static string StringCalc10(string s1, string s2, string s3)
        {
            StringBuilder sb = new StringBuilder(100);
            sb.Append(s1);
            sb.Append(", ");
            sb.Append(s2);
            sb.Append(", ");
            sb.Append(s3);
            
            return sb.ToString();
        }
    }
}
