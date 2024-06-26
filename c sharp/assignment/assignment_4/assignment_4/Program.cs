using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your first name:  ");
            string firstname = Console.ReadLine();

            Console.WriteLine("enter your last name:  ");
            string lastname = Console.ReadLine();

            name.display(firstname, lastname);


            Console.Read();
        }
    }
    class name
    {
        

        public static void display(string firstname,string lastname)
        {
            Console.WriteLine(firstname.ToUpper());
            Console.WriteLine(lastname.ToUpper());
        }
    }
}
