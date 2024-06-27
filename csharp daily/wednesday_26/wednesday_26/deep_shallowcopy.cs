using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wednesday_26
{
    class persondetailes
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public persondetailes(string f,string l)
        {
            this.firstname = f;
            this.lastname = l;
        }
    }
    class presons
    {
        public int age;
        public persondetailes pd;  //composition

        public  presons(int age,string fn,string ln)
        {
            age = age;
            pd = new persondetailes(fn, ln);
        }

        public object shallowcopy()
        {
            return this.MemberwiseClone();
        }



        public presons deepcopy()
        {
            presons dcopy = new presons(this.age, pd.firstname, pd.lastname);
            return dcopy;
        }
    }
    class deep_shallowcopy
    {
        public static void Main()
        {
            presons p1 = new presons(22, "hamsa", "ramesh");

            // presons p2 = p1

            presons p2 = (presons)p1.shallowcopy();
            Console.WriteLine($"the firstname is {p1.pd.firstname},and lastname is {p1.pd.lastname}");
            Console.WriteLine("..........................................");
            Console.WriteLine($"the firstname is {p2.pd.firstname},and lastname is {p2.pd.lastname}");

        }
    }
}
