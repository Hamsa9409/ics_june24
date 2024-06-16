using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_1
{
    class nullable
    {
        public static void nullexample()
        {
            int ? data1 = 100;
            
            int data2;
            data2 = (int)data1;
            if (data1==null)
            {
                data2 = 0;
            }
            else
            {
                data2 = (int)data1;
                //data2 = data1.Value;
                Console.WriteLine(data2);
                Console.Read();
            }
        }
    }
}
