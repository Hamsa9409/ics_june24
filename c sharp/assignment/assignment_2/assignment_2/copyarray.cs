using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_2
{
    class copyarray
    {
        public static void Main()
        {
            int[] arr1 = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int[] arr2 = new int[arr1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr2[i] = arr1[i];
            }
            Console.WriteLine("first array is " + arr1);
            Console.WriteLine("copied array is " + arr2);
            Console.Read();




        }
    }
}
