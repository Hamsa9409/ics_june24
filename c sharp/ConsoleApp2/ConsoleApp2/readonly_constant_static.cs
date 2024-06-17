using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class readonly_constant_static
    {
        // readonly variables declaration
        public readonly int myvar1 = 10;
        public readonly string mydata;

        //constructor

        public readonly_constant_static()
        {
            Console.WriteLine(myvar1);
            myvar1 = 20;
            mydata = "readonly variable";
            Console.WriteLine("value of myvar is {0), and my data is {1}",myvar1,mydata);
        }
        public static void Main()
        {
            readonly_constant_static rcs = new readonly_constant_static();
            Console.WriteLine(rcs.myvar1 + " "+ rcs.mydata);
            Console.Read();

        }
    }
}
