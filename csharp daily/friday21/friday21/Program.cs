using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace friday21
{
    interface Icustomer
    {
        void print(string msg);
        int add(int x, int y, int z);
    }
    class customer : Icustomer
    {
        public int add(int x,int y,int z)
        {
            z = x + y;
            return z;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
