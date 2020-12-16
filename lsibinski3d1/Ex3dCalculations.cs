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
            result = sbResult.ToString();
            return result.Remove(result.LastIndexOf(", "));

        }

        public static int ValueCount(int[] values, int searchValue)
        {
            int count = 0;
            foreach (int value in values)
            {         
               if (value == searchValue)
                    count ++;
            }
            return count;
        }

        public static int RangeCount(int[] values, int searchMin, int searchMax)
        {
            //     increment counter if current value between min and max (inclusive)
            int count = 0;
            foreach (int value in values)
            {
                if (value <= searchMax || value == searchMin)
                    count ++;
            }
            return count;
        }
    }
}
