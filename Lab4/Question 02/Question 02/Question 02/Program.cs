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
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double sum = num1 + num2;
            double subtraction = num1 + num2;
            double multiplication = num1 * num2;
            double division = num1 / num2;

            Console.WriteLine("sum: " + sum);
            Console.WriteLine("subtraction: " + subtraction);
            Console.WriteLine("multiplication: " + multiplication);
            Console.WriteLine("division: " + division);

            Console.ReadKey();



        }
    }
}
