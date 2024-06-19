using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter the first number:");
            //int num1 = int.Parse(Console.ReadLine());
            ////int num1 = Console.ReadLine();
            ////Console.WriteLine("Enter the first number:");
            ////int num1 = (int)Console.ReadLine();

            //Console.WriteLine("Enter the second number:");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            ////int num2 = Console.ReadLine();

            //Console.WriteLine($"Before swapping: num1 = {num1}, num2 = {num2}");

            //// Swapping logic using a temporary variable
            //int temp = num1;
            //num1 = num2;
            //num2 = temp;

            //Console.WriteLine($"After swapping: num1 = {num1}, num2 = {num2}");




            //Console.WriteLine("Enter a string:");
            //string input = Convert.ToString(Console.ReadLine());

            //// Convert string to char array
            //char[] charArray = input.ToCharArray();
            //Console.WriteLine(charArray);

            //// Reverse the char array
            //Array.Reverse(charArray);

            //// Create a new string from the reversed char array
            //string reversedString = new string(charArray);

            //Console.WriteLine($"Reversed string: {reversedString}");
            //Console.WriteLine("Enter any String : ");
            //string str = Convert.ToString(Console.ReadLine());

            //Console.WriteLine("Enter the index of Char, you want to remove : ");
            //int idx = Convert.ToInt32(Console.ReadLine());

            //string newStr = "";
            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (i != idx)
            //    {
            //        newStr += str[i];
            //        continue;
            //    }

            //}
            //Console.WriteLine(newStr);
            //Console.WriteLine("Enter Name : ");
            //string str = Convert.ToString(Console.ReadLine());
            //int last = str.Length;
            //string newStr = string.Empty;
            //newStr += str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1);
            //Console.WriteLine(newStr);








            //Console.WriteLine("Enter a string:");
            //string input = Console.ReadLine();

            // Using a loop to reverse the string
            //string reversedString = "";
            //for (int i = input.Length - 1; i >= 0; i--)
            //{
            //    reversedString += input[i];
            //}

            //Console.WriteLine($"Reversed string: {reversedString}");







            Console.WriteLine("enter size of an array");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n] ;

            // Initialize variables to store maximum and minimum values
            int max = numbers[0]; // Assume the first element is the maximum
            int min = numbers[0]; // Assume the first element is the minimum

            // Iterate through the array to find maximum and minimum values
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i]; // Update max if current element is larger
                }
                if (numbers[i] < min)
                {
                    min = numbers[i]; // Update min if current element is smaller
                }
            }

            // Print the results
            Console.WriteLine($"Maximum value in the array: {max}");
            Console.WriteLine($"Minimum value in the array: {min}");
            Console.Read();
        }
    }
}
