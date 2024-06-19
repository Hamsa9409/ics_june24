using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cc_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //remove();
            //mul();
            
            //swapfirstandlastchar();
            findlargenum();
            Console.Read();

        }
        public static void remove()
        {
            



            Console.WriteLine("Enter any NAME : ");
            string name = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter the digit of name you want to remove : ");
            int digit = Convert.ToInt32(Console.ReadLine());
            string newname = " ";
            for (int i = 0; i < name.Length; i++)
            {

                if (i == digit)
                {
                    continue;
                }
                else
                {
                    newname += name[i];
                }
            }
            Console.WriteLine(newname);



        }
        public static void mul()
        {
            Console.WriteLine("enter the num");
            int num = Convert.ToInt32(Console.ReadLine());
            for ( int i = 0; i <=10; i++)
            {
                Console.WriteLine($"{num} * {i} = {num * i}");

            }
        }
        public static void swapfirstandlastchar()
        {
            Console.WriteLine("enter the string");
            string str = Convert.ToString(Console.ReadLine());
            char[] array = str.ToCharArray();
            char temp = array[0];
            array[0] = array[array.Length - 1];
            array[array.Length - 1] = temp;

            Console.WriteLine(array);
        }
        public static void findlargenum()
        {
            Console.WriteLine("enter num 1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num 1");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num 1");
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num1>num2 && num1>num2)
            {
                Console.WriteLine(num1);

            }
            else if (num2 > num3 && num2 > num1)
            {
                Console.WriteLine(num2);

            }
            else
            {
                Console.WriteLine(num3);

            }

        }
        

    }
}
