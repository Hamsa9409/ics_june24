using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tuesday18;

namespace tuesday18_2
{
    class callingprogram
    {
        static void Main(string[] args)
        {
            Program progra = new Program();
            progra.fvar = 500.55f;
            Program.s = "hhh";
            //Console.WriteLine();


            callingprogram cp = new callingprogram();
            cp.pt = 18;

        }
    }
}
