using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace friday
{
    class array
    {
        public static void justarry()
        {
            int[] data = new int[5] { 100, 22, 38, 46, 59 };
            Console.WriteLine(data.Length);
            Console.WriteLine(data.Rank);
            Console.WriteLine("......before sort....");
            foreach (int x in data)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("....after sort......");
            Array.Sort(data);
            foreach (int x in data)
            {
                Console.WriteLine(x);
            }
            Array.Reverse(data);
            foreach (int x in data)
            {
                Console.WriteLine(x);
            }
            string[] str = new string[2] { "hello", "hamsa" };
            foreach (string s in str)
            {
                Console.WriteLine(s);
            }
        }
        public static void twodimensionarray()
        {
            int[,] arr = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            //for (int i=0;i<2;i++)

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                //for (int j=0;j<3;j++)
                for (int j = 0; j < arr.GetLength(1); j++)

                {
                    Console.Write(arr[i, j] + "     ");
                }
                Console.WriteLine();
            }
        }
        public static void differentmethodtwodimen()
        {
            Console.WriteLine("enter the num of rows");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the num of column");
            int column = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[] { };
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                //for (int j=0;j<3;j++)
                for (int j = 0; j < arr.GetLength(1); j++)

                {
                    Console.Write(arr[i, j] + "     ");
                }
                Console.WriteLine();

            }
        }
    }
}
