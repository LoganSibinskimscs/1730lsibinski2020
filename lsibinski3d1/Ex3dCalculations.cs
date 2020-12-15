using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lsibinski3d1
{
    public class Ex3dCalculations
    {
        public static string ArrayToString(int[] values)
        {
            string result = "";
            StringBuilder sbResult = new StringBuilder(200);
            for (int i = 0; i < values.Length; i++)
            {
                sbResult.Append(values[i]);
                sbResult.Append(", ");
                result = sbResult.ToString();
            }
            return result.Remove(83);
        }

        public static int ValueCount(int[] values, int searchValue)
        {
            int count = 0;
            foreach (int value in values)
            {         
                count =+ searchValue;
            }
            //     increment counter if current value equals searchValue
            return count;
        }

        public static int RangeCount(int[] values, int searchMin, int searchMax)
        {
            // create counter variable
            // loop
            //     increment counter if current value between min and max (inclusive)
            // return counter
            int count = 0;

            return count;
        }
    }
}
