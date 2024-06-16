using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hand1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter num 1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num 2");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine("Sum :"+sum);
            int product = num1 * num2;
            Console.WriteLine("Product:"+product);
            int sub = num1 - num2;
            Console.WriteLine("Subtraction:"+sub);
            int div= num1 / num2;
            Console.WriteLine("Division:"+div);
            Console.Read();




        }
    }
}
