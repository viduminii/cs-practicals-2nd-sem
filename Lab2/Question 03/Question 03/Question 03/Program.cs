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
            Console.Write("Enter the first number :");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number :");
            double num2 =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Sum: " + (num1 + num2));
            Console.ReadKey();


        }
    }
}
