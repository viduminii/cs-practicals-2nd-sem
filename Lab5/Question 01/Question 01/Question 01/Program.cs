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
            Console.Write("Enter an Integer: ");
            int num =int.Parse (Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Even");

            }
            else
            {
                Console.WriteLine("Odd");
            }
            Console.ReadKey();

        }
    }
}
