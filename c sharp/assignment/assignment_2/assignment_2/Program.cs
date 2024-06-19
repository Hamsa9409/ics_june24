using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //wordlength();
            //reverse();
            Program same = new Program();
            same.wordsaresame();
            Console.Read();

        }
        public static void wordlength()
        {
            Console.WriteLine("enter the word");
            string word = Convert.ToString(Console.ReadLine());
             int length = word.Length;
            Console.WriteLine("the length of the word is:" + length);
        }
        public static void reverse()
        {
            Console.WriteLine("enter the string");
            string word = Convert.ToString(Console.ReadLine());
            char[] array = word.ToCharArray();
            string newword = " ";
            for (int i =array.Length - 1; i >= 0;i--)
            {
                newword += array[i];
            }
            Console.WriteLine("the reverse of the string is :" + newword );
        }
        public void wordsaresame()
        {
            Console.WriteLine("enter the first word");
            string word1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("enter the second word");
            string word2 = Convert.ToString(Console.ReadLine());
            if (word1 == word2)
            {
                Console.WriteLine("words are same");

            }
            else
            {
                Console.WriteLine("words are not same");

            }

        }
    }
}
