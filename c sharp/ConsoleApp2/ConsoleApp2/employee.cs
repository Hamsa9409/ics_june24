using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class employee
    {
        int empid;
        string empname;
        DateTime doj;
        float salary;
        //1 constuctor
        public employee()
        {
            empid = 10;
            empname = "infinite";
            doj = Convert.ToDateTime("2/2/2024");
            salary = 50000;
        }
        //2 constructor
        public employee(int eid, string name, float sal)
        {
            empid = eid;
            empname = name;
            salary = sal;
        }
        //3 constuctor
        public employee(int eid, string name)
        {
            eid = eid;
            name = name;
        }


        ////methods functions
        public void getemployeedetails()
        {
            Console.WriteLine("enter id,name,doj and sal:");
            empid = Convert.ToInt32(Console.ReadLine());
            empname = Console.ReadLine();
            doj = Convert.ToDateTime(Console.ReadLine());
            salary = Convert.ToSingle(Console.ReadLine());
        }
        public void showdetails()
        {
            Console.WriteLine($"emp id{empid},emp name{empname},doj{doj},salary{salary}");
        }

        //distructor
        ~employee()
        {
            Console.WriteLine("bye...");
            Console.Read();

        }
    }
    class employeetest
    {
        public static void Main()
        {
            employee emp = new employee();
            //emp.getemployeedetails();
            emp.showdetails();
            emp = null;
            GC.Collect();//FORCES to clear the reference
            Console.WriteLine("........");
            employee employee2 = new employee(24, "hamsa", 50000);
            employee2.showdetails();
            employee employee3 = new employee(24, "hamsa");
            Console.Read();
        }
    }
}
