using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int total;
            int prod;
            int dif;
            int div;
            div = calculator(15, 10, out total, out prod, out dif);
            Console.WriteLine($"sum is {total},mul is {prod},sub is {dif},divi is {div}");
            Console.Read();
        }
        static int calculator(int a, int b, out int sum, out int product, out int differ)
        {
            sum = a + b;
            product = a * b;
            differ = a - b;
            return a / b;

        }
    }
}
