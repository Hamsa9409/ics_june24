using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_1
{
    class Myclass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C Sharp classes..");
            Console.WriteLine("Please Enter Your FirstName :");
            string fname = Console.ReadLine();
            Console.WriteLine("Please Enter Your LastName :");
            string lname = Console.ReadLine();
            
            Console.WriteLine("Your First Name is :" + fname + " and LastName is " + lname);  //concatenation
            Console.WriteLine("your First Name is :{0}, and Last Name is :{1}", fname, lname); //placeholder substitution
            Console.WriteLine($"Your FirstName is {fname} and Lastname is {lname}"); //string interpolation
            //to call nonstatic function we need to have a object
            Myclass myclass = new Myclass();
            myclass.Display("hamsa");
            //to call static function we dont need the object
            int sum = Addnum(2, 2);
            Console.WriteLine("total is" + sum);

            Console.Read();

        }
        void Display(string username)  //function signature
        {
            Console.WriteLine("welcome" + username);//function definition/body/
        }
        static int Addnum(int num1, int num2)
        {
            return num1 + num2;

        }
    }
}
