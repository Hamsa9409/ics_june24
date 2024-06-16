using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace friday
{
    class decisi
    {
        public static void checkgrade()
        {
            char grade;
            int mathscore = 75;
            Console.WriteLine("enter your grade: ");
            grade = Convert.ToChar(Console.ReadLine());
            if (grade == 'o' || grade == 'O' && mathscore > 75)
                Console.WriteLine("OUTSTANDING");
            else if (grade == 'A' || grade == 'a')
                Console.WriteLine("excellent");
            else if (grade == 'B' || grade == 'b')
                Console.WriteLine("good");
        }
        public static void checkgradewithswitch()
        {
            Console.WriteLine("enter you grade");
            Char grade = Convert.ToChar(Console.ReadLine());
            switch (grade)
            {
                case 'o':
                case 'O':
                    Console.WriteLine("OUTSTANDING");
                    break;
                case 'A':
                case 'a':
                    Console.WriteLine("excellent");
                    break;
                default:
                    Console.WriteLine("invalid");
                    break;
            }
        }
    }
    class loops
    {
        public static void whilelooop()
        {
            int i = 1;
            while(i<10)
            {
                Console.WriteLine(i);
                i++;
            }
        }
        public static void dowhileloop()
        {
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;

            } while (i < 5);

        }
        public static void forloop()
        {
            int total = 0;
            for(int i=1; i<=5; i++)
            {
                if (i == 3)
                    //break;
                continue;
                total += i;
                Console.WriteLine(i);
            }
            Console.WriteLine("the sum is {0}",total);

        }
        public static void impicittype()
        {
            var mydata = "abd";// implicitly typed variable
            dynamic d;//a reference type
            d = 6;
            d = 'b';
            d = "hello";
            Console.WriteLine(d);
            Console.WriteLine(mydata);
        }
    }
}
