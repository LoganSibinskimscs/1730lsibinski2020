using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lsibinski3b1
{
    public class Ex3bCalculations
    {
        public static decimal GetDiscountPercent(decimal subtotal)
        {
            decimal discountPercent = 0m;

            if (subtotal >= 500m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;

            return discountPercent;
        }

        public static decimal CalculateFutureValue(decimal monthlyInvestment, decimal monthlyIntrestRate, int months)
        {
            decimal futureValue = 0m;
                for (int i = 0; i < months; i++)
                {
                    futureValue = (futureValue + monthlyInvestment) * (1 + monthlyIntrestRate);
                }

            return futureValue;
        }

        public static double FahrenheitToCelsius(double f)
        {                     
                return 5.0 / 9.0 * (f - 32);          
        }

        public static decimal GrossPay(decimal hours, decimal rate)
        {
            decimal baseHours = 40m;
            decimal overTimeRate = 1.5m;

            decimal basePay;
            decimal overTimeHours;
            decimal overTimePay;
            decimal grosspay;

            if (hours > baseHours)
            {
                basePay = rate * baseHours;

                overTimeHours = hours - baseHours;

                overTimePay = overTimeHours * rate * overTimeRate;

                grosspay = basePay + overTimePay;
            }
            else
            {
                grosspay = hours * rate;
            }
            return grosspay;
        }
        
        public static decimal TotalHours(string strNumbers)
        {
            decimal total = 0;
            int startIndex = 0;

            while (startIndex < strNumbers.LastIndexOf(' '))
            {
                int endIndex = strNumbers.IndexOf(' ', startIndex);
                string strNumber = strNumbers.Substring(startIndex, endIndex - startIndex);
                Decimal number = Decimal.Parse(strNumber);
                total += number;
                startIndex = endIndex + 1;
            }


            return total;
        }

        public static decimal GrossPay(string strNumbers, decimal rate)
        {
            decimal totalHours = TotalHours(strNumbers);
            return GrossPay(totalHours, rate);
        }

        public static void CalculateFutureValue(decimal monthlyInvestment, decimal monthlyIntrestRate, int months, ref decimal futureValue)
        {
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyIntrestRate);
            }
        }

        public static void GetDiscountPercent(decimal subtotal, out decimal discountPercent)
        {
            if (subtotal >= 500m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;
        }

        public static void CelsiusToFahrenheit(double celsius, out double fahrenheit)
        {
            fahrenheit = celsius * 1.8 + 32;
        }
    }
}
