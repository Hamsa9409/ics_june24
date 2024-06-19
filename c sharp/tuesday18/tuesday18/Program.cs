using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuesday18
{
    public class Program
    {
        static int data1;//private static
        string str;// private non static
        public float fvar;//public non static
        public static string s;//public and static
        internal int i;//internal member
        internal static double d;//internal member static
        static void Main(string[] args)
        {
            Program pgr = new Program();
            Console.WriteLine(data1 + " " +pgr.str + " " + pgr.fvar + " "+s);
            Console.WriteLine(d  + " " +pgr.i);
            Console.Read();
        }
    }
    class driver
    {
        public static void accessprogram()
        {
            Program pr = new Program();
            //pr.cannot access the private memmbers of other class visibility
            pr.fvar = 23.5f;
            Program.s = "hello";//public static 
            pr.i = 46;//nonstatic  internal member accesde in another class of the same
            Program.d = 55.24;
        }
    }
    
}

