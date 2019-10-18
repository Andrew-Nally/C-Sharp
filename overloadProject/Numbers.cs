using System;
using System.Collections.Generic;
using System.Text;

namespace overloadProject
{
    class Numbers
    {
        public static void numInput(int a)
        {
            int newNum = a / 2;
            Console.WriteLine(a + " divided by 2 is: " + newNum);
        }

        public void FirstName(out string x, out string y)
        {
            Console.WriteLine("Enter your first name: ");
            x = Console.ReadLine();
            Console.WriteLine("Enter your last name:");
            y = Console.ReadLine();
        }

        public int Overload(int m, int n)
        {
            int sum = m + n;
            return sum;
        }

        public double Overload(double m, double n)
        {
            double sub = m - n;
            return sub;
        }
    }
}
