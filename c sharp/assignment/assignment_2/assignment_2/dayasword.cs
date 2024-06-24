using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_2
{
    class dayasword
    {
        enum days { monday = 1, tuesday = 2, wednesday = 3, thursday = 4, friday = 5, saturday = 6, sunday = 7 }

        public static void Main()
        {
            foreach (int x in Enum.GetValues(typeof(days)))
            {
                if (x == 1)
                    Console.WriteLine(Enum.GetNames(typeof(days)) );
                else if (x == 2)
                    Console.WriteLine(Enum.GetNames(typeof(days)));
                else if (x == 3)
                    Console.WriteLine(Enum.GetNames(typeof(days)));
                else if (x == 4)
                    Console.WriteLine(Enum.GetNames(typeof(days)));
                else if (x == 5)
                    Console.WriteLine(Enum.GetNames(typeof(days)));
                else if (x == 6)
                    Console.WriteLine(Enum.GetNames(typeof(days)));
                else if (x == 7)
                    Console.WriteLine(Enum.GetNames(typeof(days)));
            }
            Console.Read();

        }
    }
}
