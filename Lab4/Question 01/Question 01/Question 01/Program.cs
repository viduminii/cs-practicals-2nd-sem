using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number one: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter number two: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double sum = num1 + num2;
            Console.WriteLine("sum: " +(num1 + num2));
            Console.ReadKey();



        }
    }
}
