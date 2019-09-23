using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number + " multiplied by 50 = " + number * 50);
            Console.WriteLine("Enter another number:");
            int addNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(addNumber + " plus 25 = " + (addNumber + 25));
            Console.WriteLine("Enter a third number:");
            double divideNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(divideNumber + " divided by 12.5 = " + divideNumber / 12.5);
            Console.WriteLine("Let's do a fourth number:");
            int greaterThan = Convert.ToInt32(Console.ReadLine());
            bool isGreaterThan = greaterThan > 50;
            Console.WriteLine(isGreaterThan);
            Console.WriteLine("Let's do something new... enter a number :)");
            int mod = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(mod + "'s remainder when divided by 7 is: " + mod % 7);
            Console.ReadLine();
        }
    }
}
