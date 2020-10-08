using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lsibinski2e1
{
    public class LogicalOperations
    {
        public static bool q01(decimal subtotal)
        {
            return subtotal >= 250 && subtotal < 500;
        }

        public static bool q02(int timeInService)
        {
            return timeInService <= 4 || timeInService >= 12;
        }

        public static bool q03(bool isValid, int years, int counter)
        {
            return isValid == true && counter++ < years;
        }

        public static bool q04(bool isValid, int years, int counter)
        {
            return isValid == true & counter++ < years;
        }

        public static bool q05(bool isValid, int years, int counter)
        {
            return isValid == true || counter++ < years;
        }

        public static bool q06(bool isValid, int years, int counter)
        {
            return isValid == true | counter++ < years;
        }

        public static bool q07(DateTime startDate, DateTime expirationDate, DateTime date, bool isValid)
        {
            return date > startDate && date < expirationDate || isValid == true;
        }

        public static bool q08(decimal thisYTD, decimal lastYTD, string empType, int startYear, int currentYear)
        {
            return ((thisYTD > lastYTD) || empType == "Part time") && startYear < currentYear;
        }

        public static bool q09(int counter, int years)
        {
            return !(counter++ >= years);
        }

        public static bool q10(int a, int b, int c, int d)
        {
            return a > b && b < c || c < d;
        }

        public static bool q11(bool member, decimal price, float weight)
        {
            return member == true || price >= 25m || weight <= 1.0f;
        }

        public static bool q12(bool member, decimal price, float weight)
        {
            return member == true || price >= 25m && weight < 1.0f;
        }

        public static bool q13(string shipState, string itemType)
        {
            return shipState == "MN" && !(itemType == "Clothing" || itemType == "Food");
        }
    }
}
