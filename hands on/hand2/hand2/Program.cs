using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hand2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first integer");
            string first = Console.ReadLine();

            Console.WriteLine("enter the second integer");
            string second = Console.ReadLine();
            if(first==second)
            {
                Console.WriteLine("integer is equal");
                Console.ReadLine();

                
            }
            else
            {
                Console.WriteLine("invalid");
                Console.Read();
            }
        }
    }
}
