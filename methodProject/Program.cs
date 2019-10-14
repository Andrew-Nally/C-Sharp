using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            Numbers number = new Numbers();
            Console.WriteLine("Please enter a whole number:");
            string userInput = Console.ReadLine();
            int convertInput = Convert.ToInt32(userInput);
            Multiply(convertInput);
            Add(convertInput);
            Subtract(convertInput);
            Console.ReadLine();
        }

        public static void Multiply(int a)
        {
            int mult = a * 10;
            Console.WriteLine(a + " multiplied by 10 is: " + mult);
        }

        public static void Add(int a)
        {
            int add = a + 300;
            Console.WriteLine(a + " plus 300 is: " + add);
        }

        public static void Subtract(int a)
        {
            int sub = a - 1;
            Console.WriteLine(a + " subtracted by 1 is: " + sub);
        }
    }
}

