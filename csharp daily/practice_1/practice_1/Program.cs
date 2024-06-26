using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_1
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Employee e1 = new Employee();
    //        Employee e2 = new Employee();
    //        Console.Read();
    //    }
    //}
    //public class Employee
    //{
    //    public Employee()
    //    {
    //        Console.WriteLine("Default Constructor Invoked");
    //    }
    //}











    // parametirsed constructor

    
    public class Employee
    {
        public int id;
        public String name;
        public float salary;
        public Employee(int i, String n, float s)
        {
            id = i;
            name = n;
            salary = s;
        }
        public void display()
        {
            Console.WriteLine(id + " " + name + " " + salary);
        }
    }
    class TestEmployee
    {
        public static void Main(string[] args)
        {
            Employee e1 = new Employee(101, "hamsa", 890000);
            Employee e2 = new Employee(102, "ramesh", 490000);
           
            e1.display();
            e2.display();
            Console.Read();


        }
    }
}




