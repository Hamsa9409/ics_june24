using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_4
{
    class class1
    {
        static void Main()
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            Console.Write("Enter the letter to count: ");
            char countletter = Console.ReadLine()[0]; 

            int count = letterrepeat(str, countletter);

            Console.WriteLine($"Number of occurrences of '{countletter}' in the string: {count}");

            Console.Read();
        }

        static int letterrepeat(string str, char countletter)
        {
            int count = 0;
            foreach (char c in str)
            {
                if (c == countletter)
                {
                    count++;
                }


                   
                
            }
            return count;
        }
    }
}
