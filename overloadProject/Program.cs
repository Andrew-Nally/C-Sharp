using System;

namespace overloadProject
{
    class Program
    {
        public static void Main(string[] args)
        {
            Numbers number = new Numbers();
            Numbers name = new Numbers();
            Numbers sum = new Numbers();
            Console.WriteLine("Please enter a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Numbers.numInput(userInput);
            name.FirstName(out string x, out string y);            
            Console.WriteLine("Hello " + x + " " + y + "!");
            int sum1 = sum.Overload(1, 2);
            Console.WriteLine("1 + 2 = " + sum1);
            double sub1 = sum.Overload(8.3, 9.1);
            Console.WriteLine("8.3 - 9.1 = " + sub1);
            Console.ReadLine();
        }
    }
}
