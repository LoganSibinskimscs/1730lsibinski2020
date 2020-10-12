using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lsibinski2f1
{
    public class Ex2fCalculations
    {
        public static string Calc01(string input)
        {
            // #1: if
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = Decimal.Parse(input);
            if (subtotal >= 100m)
                discountPercent = 0.2m;
            return discountPercent.ToString("n2");
        }

        public static string Calc02(string input)
        {
            // #2: if {block}
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = Decimal.Parse(input);
            discountPercent = 0m;
            string status = "Standard rate: ";
            if (subtotal >= 100m)
            {
                discountPercent = 0.2m;
                status = "Bulk rate: " + discountPercent.ToString("n2");
            }
            return status;
        }

        public static string Calc03(string input)
        {
            // #3: if else
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = Decimal.Parse(input);
            discountPercent = 0m;
            if (subtotal >= 100m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;
            return discountPercent.ToString("n2");
            
        }

        public static string Calc04(string input)
        {
            // #4 if else if
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = Decimal.Parse(input);
            discountPercent = 0m;
            if (subtotal >= 100m && subtotal < 200m)
                discountPercent = 0.2m;
            else if (subtotal >= 200m && subtotal < 300m)
                discountPercent = 0.3m;
            else if (subtotal >= 300m)
                discountPercent = 0.4m;
            else
                discountPercent = 0.1m;
            return discountPercent.ToString("n2");
        }

        public static string Calc05(string input)
        {
            // #5 Better range test
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = Decimal.Parse(input);
            discountPercent = 0m;
            if (subtotal >= 300m)
                discountPercent = 0.4m;
            else if (subtotal >= 200m)
                discountPercent = 0.3m;
            else if (subtotal >= 100m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;
            return discountPercent.ToString("n2");
        }

        public static string Calc06(string inputA, string inputB)
        {
            // #6 Nested if
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = Decimal.Parse(inputA);
            string customerType =inputB;
            discountPercent = 0m;
            if (customerType == "R")
            {
                if (subtotal >= 100m)
                    discountPercent = 0.2m;
                else
                    discountPercent = 0.1m;
            }
            else           // customerType isn't "R"
                discountPercent = 0.4m;
            return discountPercent.ToString("n2");
        }

        public static string Calc07(string input)
        {
            // #7 Validate input: non-empty string
            decimal ethereum = 0m;
            if (input != "")
            {
                decimal dollars = Decimal.Parse(input);
                ethereum = 200m * dollars;
                return ethereum.ToString("n2");
            }
            return "Invalid input";

        }

        public static string Calc08(string inputA, string inputB)
        {
            // #8 Validate input, calculate quantity * price, shipping
            decimal total = 0m;
            decimal shipping = 0m;
            decimal cost = 0m;
            if (inputA != "" && inputB != "")
            {
                decimal quantity = Decimal.Parse(inputB);
                decimal price = Decimal.Parse(inputA);
                cost = quantity * price;
                if (cost < 50m)
                    shipping = 5m;
                total = quantity * price + shipping;
                return total.ToString("n2");
            }
            return "Invalid input";
        }

        public static string Calc09(string inputA, string inputB)
        {
            // #9 Validate input, calculate difference * rate
            decimal total = 0m;
            decimal rate = 0.10m;
            if (inputA != "" && inputB != "")
            {
                decimal leftRate = Decimal.Parse(inputB);
                decimal rightRate = Decimal.Parse(inputA);
                if (leftRate > rightRate)
                    total = (leftRate - rightRate) * rate;
                else if (leftRate < rightRate)
                    return "Invalid input";
                return total.ToString("n2");
            }
            return "Invalid input";
        }

        public static string Calc10(string inputA, string inputB)
        {
            // #10 Validate input, divide large num by small
            //     Both numbers must be > 0
            decimal result = 0m;
            if (inputA != "" && inputB != "")
                if (inputA != "0" && inputB != "0")
                { 
                    decimal left = Decimal.Parse(inputA);
                    decimal right = Decimal.Parse(inputB);
                    if (left < 0m)
                    {
                        return "Invalid input";
                    }
                    else if (right < 0m)
                    {
                        return "Invalid input";
                    }
                    if (left > right)

                        result = left / right;
                    else
                        result = right / left;
                    return result.ToString("n2");
                }
            return "Invalid input";
        }
    }
}
