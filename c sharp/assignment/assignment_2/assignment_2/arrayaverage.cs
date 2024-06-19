using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_2
{
    class arrayaverage
    {
        public static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int sum = 0;
            for (int i=0;i<arr.Length;i++)
            {
                sum += arr[i];
            }
            Console.WriteLine($"the average is {sum/arr.Length}");
            int minvalue = arr[0];
            int maxvalue = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < minvalue)
                {
                    minvalue = arr[i];

                }
                else if ((arr[i] > maxvalue))
                {
                    maxvalue = arr[i];

                }
            }
            Console.WriteLine("minimum value is" + minvalue);
            Console.WriteLine("maximum value is" + maxvalue);
            Console.Read();

        }
    }
}
