using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_3
{
    class customerdetailes
    {
        public int customerid;
        public string name;
        public int age;
        public int phoneno;
        public string city;


        public customerdetailes()
        {
            Console.WriteLine("empty constructor");
        }
        public customerdetailes(int customerid, string name, int age, int phoneno, string city)
        {
            this.customerid = customerid;
            this.name = name;
            this.age = age;
            this.phoneno = phoneno;
            this.city = city;
        }
        ~customerdetailes()
        {
            Console.WriteLine("destructor");

        }
        public void display()
        {
            Console.WriteLine("custumer id:  " +  customerid + " name:  " + name + " age:  " + age + " phoneno:  " + phoneno +  " city:  " + city);
        }
    }
    class test
    {
        public static void Main()
        {
            customerdetailes customer1 = new customerdetailes();
            customer1.display();
            customerdetailes customer2 = new customerdetailes(1035487,"hamsa",22,987654321,"bengaluru");
            customer2.display();

            Console.Read();


        }
    }
}
