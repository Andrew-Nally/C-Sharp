using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace incomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Please enter Person 1's hourly rate:");
            double hourlyOne = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How many hours does Person 1 work per week?:");
            byte hoursOne = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Person 2:");
            Console.WriteLine("Please enter Person 2's hourly rate:");
            double hourlyTwo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How many hours per week does Person 2 work?:");
            byte hoursTwo = Convert.ToByte(Console.ReadLine());
            int personOne = Convert.ToInt16(hourlyOne * hoursOne);
            int personTwo = Convert.ToInt16(hourlyTwo * hoursTwo);
            Console.WriteLine("Weekly salary of Person 1: " + personOne);
            Console.WriteLine("Weekly Salary of Person 2: " + personTwo);
            Console.WriteLine("Does Person 1 make more than Person 2?");
            bool comparison = personOne > personTwo;
            Console.WriteLine(comparison);
            Console.ReadLine();
        }
    }
}
