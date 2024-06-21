using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hand4
{               // program for swaping two numbers
    class Program
    {
        static void Main(string[] args)
        {
            swap();
            Class1.dimension();
            Console.Read();
            


        }
        public static void swap()
        {
            Console.WriteLine("enter a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter b");
            int b = Convert.ToInt32(Console.ReadLine());
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("afterswap a=" + a);
            Console.WriteLine("afterswap b=" + b);

        }
    }
}
