using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structProject
{
    class Program
    {
        public struct Number
        {
            public double Amount { get; set; }

        }
        static void Main(string[] args)
        {
            Number number = new Number();
            number.Amount = 34.5;

            Console.WriteLine("Amount = " + number.Amount);
            Console.ReadLine();
        }
    }
}
