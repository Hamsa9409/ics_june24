using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hand4
{
    class Class1
    {                   //program for format printing
        public static void dimension()
        {
            Console.WriteLine("enter the number");
            int mat = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} {0} {0} {0}",mat);
            Console.WriteLine("{0}{0}{0}{0}",mat);
            Console.WriteLine("{0} {0} {0} {0}",mat);
            Console.WriteLine("{0}{0}{0}{0}",mat);
            Console.Read();
        }
    }
}
