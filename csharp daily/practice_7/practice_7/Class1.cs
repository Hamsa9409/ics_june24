using System;
using System.Collections.Generic;
using System.Linq;

class Class1
{
    static void Main()
    {
        List<string> words = new List<string> { "amsterdam", "bloom", "apple", "apex", "elm" };

        Console.WriteLine("Enter starting character:");
        string startChar = Console.ReadLine(); // Read starting character from user

        Console.WriteLine("Enter ending character:");
        string endChar = Console.ReadLine(); // Read ending character from user

        var result = words
            .Where(word => word.ToLower().StartsWith(startChar.ToLower()) &&
                           word.ToLower().EndsWith(endChar.ToLower()))
            .ToList();

        Console.WriteLine($"Words starting with '{startChar}' and ending with '{endChar}':");

        foreach (var word in result)
        {
            Console.WriteLine(word);
        }

        Console.ReadLine(); // Keep console window open until user presses Enter
    }
}