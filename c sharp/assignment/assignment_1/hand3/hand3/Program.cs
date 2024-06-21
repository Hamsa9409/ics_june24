using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hand3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int i =int.Parse( Console.ReadLine());
            
            if (i > 0) 
            {
                Console.WriteLine("positive num");
                Console.Read();
            }
            else
            {
                Console.WriteLine("negative num");
                Console.Read();

            }
        }
    }
}
