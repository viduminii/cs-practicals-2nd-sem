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
            Console.Write("Enter your salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter tax rate: ");
            double tax = Convert.ToDouble(Console.ReadLine());
            // double new_salary = salary * (100 - tax) / 100;
            double new_salary = salary - (salary * (tax / 100));
            Console.WriteLine("New Salary: " + new_salary);
            Console.ReadKey();
        }
    }
}
