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
            Console.Write("Enter Username :");
            String name = Console.ReadLine();
            Console.Write("Enter Your Batch :");
            String batch = Console.ReadLine();

            Console.WriteLine("Enter Username :" + name);
            Console.WriteLine("Enter your Batch :" + batch);
            Console.ReadKey();
        }
    }
}
