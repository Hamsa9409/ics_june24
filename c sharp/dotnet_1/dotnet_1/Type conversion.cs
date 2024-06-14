using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_1
{
    class Type_conversion
    {
        static void Main()
        {
            // simpleconvr();
            // boxing_unboxing();
            ternaryfunction();
            
            //Type_conversion typecnvr = new Type_conversion();
            //bool res = typecnvr.ternaryfunction();
            //Console.WriteLine(typecnvr.ternaryfunction);
            Console.Read();
        }
        static void ternaryfunction()
        {
            int num = 10;//assigning
            bool b;
            if (num == 10)//checking for a specific value
            {
                b = true;

            }
            else
                b = false;
            Console.WriteLine(b);
            b = num == 10 ? true : false;
            Console.WriteLine(b);

        }
        static void boxing_unboxing()
        {
            int x = 10;//value type
            object obj;//reference type
            obj = x;//converting value type to reference type-boxing
            Console.WriteLine($"value of x {x}");
            Console.WriteLine($"value if obj {obj}");
            string sr= "www";//refernce type
            obj = sr;//reference type

            float salary;
            Console.WriteLine("please enter your salary");
            salary = float.Parse(Console.ReadLine()); //string to float is unboxing 

            salary = Convert.ToSingle(Console.ReadLine());


        }
        static void simpleconvr()
        {
            int i = 100;
            Console.WriteLine("the valueof int:" + i);
            float f = i;//implicit conversion
            Console.WriteLine("the value of float:" + f);
            f = 123.45f;
            i = (int)f;//explicit conversion using typecast
            Console.WriteLine("..........");
            Console.WriteLine(i);

            i = Convert.ToInt32(f);//explicit conversion using conversion function
            Console.WriteLine(i);
            //parsing is converting one data type into another data type
            //using parse and try parse
            string str = "100";
            i = int.Parse(str);//will convert the string into iint
            Console.WriteLine(i);


            str = "100g";
            //i = int.Parse(str);//throws an exception instead we can use tryparse to avoid exception
            int result = 0;
            bool success = int.TryParse(str, out result);
            if (success)
            {
                Console.WriteLine(result);
            }
            else
                Console.WriteLine("invalid data");
            Console.Read();

            //Console.WriteLine(i);
        }
        //boxing and unboxing
        //boxcing-converting value type to a reference type 


    }
}
