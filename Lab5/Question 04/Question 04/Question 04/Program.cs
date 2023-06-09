using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_04
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Console.Write("Enter a positive integer: ");
            int number = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= number; i += 2)
            {
                sum += i;
            }

            Console.WriteLine("Sum of odd numbers: " + sum);
        }
    }

}

