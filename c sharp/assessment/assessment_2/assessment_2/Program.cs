using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- calling the abstractclass  Student with  Name, StudentId, Grade as members -----");

            
            Undergraduate undergradStudent = new Undergraduate
            {
                Name = "hamsa",
                Id = 1035487,
                Grade = 75.0f
            };

            Console.WriteLine($"Undergraduate Student: {undergradStudent.Name}, ID: {undergradStudent.Id}, Grade: {undergradStudent.Grade}");
            Console.WriteLine($"Is Passed: {undergradStudent.IsPassed(undergradStudent.Grade)}");


            Graduate gradStudent = new Graduate
            {

                Name = "ramesh",
                Id = 9148,
                Grade = 85.0f
            };

            Console.WriteLine($"Graduate Student: {gradStudent.Name}, ID: {gradStudent.Id}, Grade: {gradStudent.Grade}");
            Console.WriteLine($"Is Passed: {gradStudent.IsPassed(gradStudent.Grade)}");
            Console.ReadLine();
        }
    }
    abstract class Student
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public float Grade { get; set; }

        public abstract bool IsPassed(float grade);
    }

    class Undergraduate : Student
    {
        public override bool IsPassed(float grade)
        {
            return grade > 70.0;
        }
    }

    class Graduate : Student
    {
        public override bool IsPassed(float grade)
        {
            return grade > 80.0;
        }
    }


}
