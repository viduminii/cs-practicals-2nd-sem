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
            Console.Write("Enter the Radius :");
            double radius = Convert.ToDouble(Console.ReadLine());
            double calculation = radius * radius * Math.PI;
            Console.WriteLine("Area: " + calculation);
            Console.ReadKey();

        }
    }
}
