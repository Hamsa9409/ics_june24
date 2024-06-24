using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_3
{
    class student
    {
        public int rollno;
        public string name;
        public int Class;
        public int sem;
        public string branch;
        public int[] marks = new int[5];
         

        public student (int rollno, string name, int Class, int sem, string branch)
        {
            this.rollno = rollno;
            this.name = name;
            this.Class = Class;
            this.sem = sem;
            this.branch = branch;
            
        }
        public void getmarks()
        {
            Console.WriteLine("enter the marks of five subjects");
            for(int i=0;i<5;i++)
            {
                Console.WriteLine($"subjects {i + 1}:");
                marks[i] = int.Parse(Console.ReadLine());
            }
        }
        public void displayresult()
        {

            int totalmarks = 0;
            bool failed = false;
            for (int i = 0; i < marks.Length; i++)
            {
                totalmarks += marks[i];
                Console.WriteLine(totalmarks);


                if (marks[i] < 35)
                {
                    Console.WriteLine("result : failed");
                    failed = true;
                    break;

                }
            }
            float average = totalmarks / 5;
            Console.WriteLine("average is :" + average);
            if (failed && average < 50)
            {
                Console.WriteLine("result : failed");
            }
            else
            {
                Console.WriteLine(" result : pass");
            }
        }
        public void display()
        {
            Console.WriteLine(" roll no:   " + rollno +" " + "name:   " + name + " " + "class:   " + Class+"  " + "sem:   " + sem+" " + "branch:    " + branch);
            //Console.WriteLine($"marks {i + 1} : {marks[i]}");
        }


    }
    public class class1
    {
        public static void Main()
        {
            student stud = new student(1035487,"hamsa",4,7,"ece");
            stud.getmarks();
            stud.displayresult();
            stud.display();
            Console.Read();
        }
    }
}
