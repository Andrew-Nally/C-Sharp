using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shipping
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("How much does the package weigh?");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("What is the package height?");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the package width?");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the package's length (Giggity)");
                int length = Convert.ToInt32(Console.ReadLine());
                if (height + length + width > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                else
                {
                    double price = Convert.ToDouble((height + length + width) * weight / 100.00);
                    Console.WriteLine("Your total price is: $" + price);
                    Console.ReadLine();
                }
            }
        }
    }
}
