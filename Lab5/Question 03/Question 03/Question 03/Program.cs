using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_03
{
    internal class Program
    
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int temp = number; temp != 0; temp /= 10)
            {
                int digit = temp % 10;
                sum += digit;
            }

            Console.WriteLine("Sum of the digits: " + sum);
        }
    }

}

