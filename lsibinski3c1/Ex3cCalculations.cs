using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lsibinski3c1
{
    public class Ex3cCalculations
    {
        public static string Calc0(int index)
        {
            string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            for (int i = 0; i < days.Length; i++)
            {
                if(index >= 1 && index <= 7)
                {
                    index = index - 1;
                    break;
                }
                else
                    return "Invalid index";
            }
            return days[index];
        }

        public static string Calc1(string search)
        {
            search = search.Trim();
            string[] days = { "SUNDAY", "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY" };
            string[] hours = { "Closed", "10am - 6pm", "10am - 6pm", "10am - 6pm", "10am - 9pm", "10am - 6pm", "8am - 4pm" };
            int index = Array.IndexOf(days, search.ToUpper());
            string hour = hours[index];
            for (int i = 0; i < days.Length; i++)
            {             
                if (index >= 0 && index <= 7)
                {
                    index = index - 1;
                    search = hour;
                    break;
                }
                else
                    return "Invalid input";
            }
            return search;
        }

        public static int Calc2(int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
                sum += number;
            return sum;
        }
        public static double Calc3(double[] numbers, int count)
        {
            double sum = 0.0;
            for (int i = 0; i < count; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
        public static double Calc5(double[] numbers)
        {
            double sum = 0.0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            double avg = sum / numbers.Length;
            return avg;
        }

        public static double[] Calc6(double[] numbers)
        {
            int length = numbers.GetLength(0);
            List<double> aboveAvgList = new List<double>();
            if (length > 0)
            {
                double avg = Calc5(numbers);
                foreach (double number in numbers)
                {
                    if (number >= avg)
                        aboveAvgList.Add(number);
                }
            }
            return aboveAvgList.ToArray();

        }
    }
}
