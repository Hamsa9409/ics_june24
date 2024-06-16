using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace friday
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 10;
            //Callbyvalue(x);
            //callbyreference(ref x);
            //decisi dec = new decisi();
            //decisi.checkgrade();
            //decisi.checkgradewithswitch();
            //loops loop = new loops();
            //loops.whilelooop();
            //loops.dowhileloop();
            //Console.WriteLine("..............");
            //loops.forloop();
            //loops.impicittype();
            //array.justarry();
            array.twodimensionarray();
            //array.differentmethodtwodimen();
            //jagged.Jagged();



            //Console.WriteLine("x  "+ x);

            /*int total;
            int prod;
            int dif;
            int mul;
            mul = calculatorfunction(15, 10, out total, out prod, out dif);
            Console.WriteLine($"sum is {total},mul is {prod},sub is {dif},mul is {mul}");*/


            Console.Read();
        }
        public static void Callbyvalue(int j)
        {
            Console.WriteLine("j is {0}", j);
            j = 100;
            Console.WriteLine("j is {0}", j);

        }
        public  static void callbyreference(ref int j)
        {
            Console.WriteLine("j is {0}", j);
            j = 108;
            Console.WriteLine("j is {0}", j);
        }
        public static int calculatorfunction(int a, int b, out int sum, out int div, out int differ)
        {
            sum = a + b;
            div = a / b;
            differ = a - b;
            return a * b;

        }
    }
}
