using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace friday21
{
    class equalsmethodexample
    {
        public  enum direction { north, south,east,west};
        public static void Main()
        {
            int number1 = 10;
            int number2 = 10;
            Console.WriteLine($"number1 == number2 : {number1 == number2}");
            Console.WriteLine("..............");
            direction d1 = direction.east;
            direction d2 = direction.east;
            Console.WriteLine(d1==d2);
            Console.WriteLine(d1.Equals(d2));
            Console.WriteLine("$$$$$$$$$$$$$");
            Equality_with_referenceTypes();
            Console.Read();


        }
        public static void Equality_with_referenceTypes()
        {
            Customers c1 = new Customers();
            c1.FirstName = "hamsa";
            c1.LastName = "ramesh";
            Customers c2 = c1;
            Console.WriteLine($"c1 == c2: {c1 == c2} {c1.GetHashCode()} and {c2.GetHashCode()}");
            Console.WriteLine($"C1.Equals(C2) : {c1.Equals(c2)}");

            Console.WriteLine("--------------------");
            c2 = new Customers();
            c2.FirstName = "hamsa";
            c2.LastName = "ramesh";

            Console.WriteLine($"C1 == C2 : {c1 == c2} {c1.GetHashCode()} and {c2.GetHashCode()}");
            Console.WriteLine($"C1.Equals(C2) : {c1.Equals(c2)}");

        }
    }

    public class Customers
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
    

