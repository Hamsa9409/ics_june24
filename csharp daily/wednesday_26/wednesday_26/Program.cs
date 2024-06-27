using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wednesday_26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("the number of generations : " + GC.MaxGeneration);
            Program p = new Program(); 
            Console.WriteLine("the gen number of the object p is " + GC.GetGeneration(p));
            Console.WriteLine("THE TOTAL MEMORY:" + GC.GetTotalMemory(true));

            GC.Collect(0);
            Console.WriteLine("the gen number of the object o is " + GC.GetGeneration(0));
            Console.Read();
        } 
    }
}
