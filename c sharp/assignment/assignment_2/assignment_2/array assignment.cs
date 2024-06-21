using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_2
{
    class array_assignment
    {
        
        public static void Main()
        {
            int[] marks = new int[10];
            for (int i=0;i<marks.Length;i++)
            {
                Console.WriteLine($" enter marks {i + 1}:");
                marks[i] = int.Parse(Console.ReadLine());

            }
            

            markscalculation(marks, out int total, out double average, out int minvalue, out int maxvalue/*, out int[] ascendingorder, out int[] descendingorder*/);

            Console.WriteLine("total marks is : "  +  total  +  "average is : "  +  average  +  "minimum value is :"  +  minvalue  +  "maximum value is :"  +  maxvalue);
            
            Console.Read();



        }
        static void markscalculation(int[] marks, out int total, out double average, out int minvalue, out int maxvalue/*,out int[] ascendingorder,out int[] descendingorder*/)
        {
            total = 0;
            foreach (int mark in marks)
            {
                total += mark;
            }


            average = (double)total / marks.Length;



            minvalue = marks[0];
            maxvalue = marks[0];
            for (int i = 1; i < marks.Length; i++)
            {
                if (marks[i] < minvalue)
                {
                    minvalue = marks[i];

                }
                else if ((marks[i] > maxvalue))
                {
                    maxvalue = marks[i];

                }
            }



        }   
    }
}
