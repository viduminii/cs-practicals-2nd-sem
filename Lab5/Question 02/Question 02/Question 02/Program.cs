using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            int vowelCount = CountVowels(input);
            Console.WriteLine("Number of vowels: " + vowelCount);
        }

        static int CountVowels(string str)
        {
            int count = 0;
            string vowels = "aeiouAEIOU";

            for (int i = 0; i < str.Length; i++)
            {
                if (vowels.Contains(str[i]))
                {
                    count++;
                }
            }

            return count;
        }
    }

}

