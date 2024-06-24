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
            Console.WriteLine("the elements of the arr2:");
            for(int i = 0; i < arr2.Length;i++)
            {
                Console.WriteLine(arr2[i]);
            }
            Console.Read();




        }
    }
}
