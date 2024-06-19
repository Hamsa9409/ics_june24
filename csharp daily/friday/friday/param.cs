using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace friday
{
    class param
    {
        public static void Main()
        {
            param prm = new param();
            int result=prm.addelements();
            Console.WriteLine("the total is:{0}", result);
            result = prm.addelements(5);
            Console.WriteLine("the total is:{0}",result);
            result = prm.addelements(1,2,3,4,5,6);
            Console.WriteLine("the total is:{0}", result);
            int[] numbers = new int[3];
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            result=prm.addelements(numbers);
            Console.WriteLine("the total is:{0}", result);

            add(5, 10.6f);
            add(10, 12.5f, 12.3, 14.6);
            Console.Read();
            


        }
        public int addelements(params int[]arr)
        {
            int sum = 0;
            foreach(int i in arr)
            {
                sum += i;
            }
            return sum;
        }
        //
        public static void add(int x, float f, params double[] d)
        {
            Console.WriteLine("{0}, {1},{2}",x,f);
            Console.WriteLine("there are [0} number of elements inthe array",d.Length);
            foreach(double db1 in d)
            {
                Console.WriteLine(db1);
            }
        }
    }
}
