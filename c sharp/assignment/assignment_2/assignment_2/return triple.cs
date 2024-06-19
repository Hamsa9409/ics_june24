using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_2
{
    class return_triple
    {
        public static void Main()
        {
            Console.WriteLine("enter the first num1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the first num2");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if ( num1 == num2)
            {
                Console.WriteLine(3 * (num1 + num2)); 
            }
            else
            {
                Console.WriteLine(num1+num2);
            }
            Console.Read();

        }
       
    }
}
