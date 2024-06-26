using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_1
{
    //class Class1        //// method overloading using same function name with different no. of arguments
    //{
    //    public static int add(int a, int b)
    //    {
    //        return a + b;
    //    }
    //    public static int add(int a, int b, int c)
    //    {
    //        return a + b + c;
    //    }
    //}
    //public class TestMemberOverloading
    //{
    //    public static void Main()
    //    {
    //        Console.WriteLine(Class1.add(12, 23));
    //        Console.WriteLine(Class1.add(12, 23, 25));
    //    }
    //}







    //method overloading with same function name and different data type
    public class Cal
    {
        public static int add(int a, int b)
        {
            return a + b;
        }
        public static float add(float a, float b)
        {
            return a + b;
        }
    }
    public class TestMemberOverloading
    {
        public static void Main()
        {
            Console.WriteLine(Cal.add(12, 23));
            Console.WriteLine(Cal.add(12.4f, 21.3f));
        }
    }
}





