using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monday17
{
    class Program
    {
        static void Main(string[] args)
        {
            //stringopr();
           struct_vs_class();
            //enumerations.enumoper();
            Console.Read();


        }
        public static void stringopr()
        {
            string s = "hello";
            Console.WriteLine("s for the first time is {0}",s.GetHashCode());

            // strings are immutable
            s = "hello world";
            Console.WriteLine("s after change value is {0}", s.GetHashCode());


            string s1 = "c sharp";
            Console.WriteLine("s1 new value from the pool {0}",s1.GetHashCode());


            string s2 = s1;//reference of s1 is assigned to s2
            Console.WriteLine("s1 {0}", s2.GetHashCode());


            string s3 = "hello";
            Console.WriteLine("s1 {0}", s3.GetHashCode());

            // mutable strings
            StringBuilder sb = new StringBuilder("hello");
            Console.WriteLine("sb's hash code:{0}",sb.GetHashCode());
            sb.Append("  world");
            Console.WriteLine("sb's hash code:{0}",sb.GetHashCode());
            Console.WriteLine(sb);
            Console.WriteLine(sb.Capacity);
        }
        public static void struct_vs_class()
        {
            //student s1;//or
            student s1 = new student();
            //student s1 = new student();
            //s1.GetHashCode()
            // valuetype
            s1.marks1 = 50;
            s1.marks2 = 60;
            Console.WriteLine(s1.marks1 + s1.marks2);

            student s2 = new student();
            //student s2;//or

            s2 = s1;
            Console.WriteLine(s2.marks1 + s2.marks2);
            Console.WriteLine("....after......");
            s1.marks1 = 40;
            s1.marks2 = 60;
            Console.WriteLine(s1.marks1 + s1.marks2);
            s2 = s1;
            Console.WriteLine(s2.marks1 + s2.marks2);
        }

    }
    class student
    {
        //public fields
        public int marks1;
        public int marks2;
        //public string name;
    }
    
}
