using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monday24
{
    class Program
    {
        static void Main(string[] args)
        {
            
            compare.compareeg();
            Console.Read();
            
        }
    }
    class  compare
    {
        public static void compareeg()
        {
            const int a = 5;
            const int b = 6;
            const int c = 8;

            Console.WriteLine(a.CompareTo(b));

            //int r1 = a.CompareTo(b);
            //-1 when the first no is smaller
            //1  when the first no is larger
            //0  when


            Console.WriteLine(b.CompareTo(a));
            Console.WriteLine(c.CompareTo(a));


            compare customer1 = new compare();
        }
    }
}
