using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user to enter the number of matches
            Console.Write("Enter number of matches: ");
            int numberOfMatches = Convert.ToInt32(Console.ReadLine());

            // Initialize variables to store sum and scores array
            int sum = 0;
            int[] scores = new int[numberOfMatches]; // Array to store scores

            // Input scores for each match
            for (int i = 0; i < numberOfMatches; i++)
            {
                Console.Write($"Enter score for match {i + 1}: ");
                scores[i] = Convert.ToInt32(Console.ReadLine());

                // Calculate sum as scores are entered
                sum += scores[i];
            }

            // Calculate average
            double average = (double)sum / numberOfMatches;

            // Display sum and average
            Console.WriteLine($"Sum of scores: {sum}");
            Console.WriteLine($"Average of scores: {average:F2}");

            // Pause console before closing (optional)
            Console.ReadLine();
        }
    }
}
