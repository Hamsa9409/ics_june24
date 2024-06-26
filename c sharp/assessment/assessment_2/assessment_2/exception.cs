using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment_2
{
    

    public class class2
    {
        public static void Main()
        {
            try
            {
                
                Console.Write("Enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());

                CheckPositiveNumber(number);

                
                Console.WriteLine("Number is positive and valid!");
            }
            
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
            Console.Read();
        }

        
        public static void CheckPositiveNumber(int number)
        {
            
            if (number < 0)
            {
                throw new ArgumentException("Number cannot be negative.");
            }
            
        }
    }

}


