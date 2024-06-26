using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_2
{
    public class Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }

        // Default constructor
        public Rectangle()
        {
            Length = 0;
            Width = 0;
        }

        // Parameterized constructor
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        // Method to calculate area
        public double CalculateArea()
        {
             return Length * Width;
        }
    }

    class Program1
    {
        static void Main()
        {
            Rectangle rect1 = new Rectangle(); // Using default constructor
            Console.WriteLine($"Area of Rectangle 1: {rect1.CalculateArea()}");

            Rectangle rect2 = new Rectangle(5.5, 3.2); // Using parameterized constructor
            Console.WriteLine($"Area of Rectangle 2: {rect2.CalculateArea()}");
        }
    }
}
