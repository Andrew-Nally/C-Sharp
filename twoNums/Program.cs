using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twoNums
{
    class Program
    {
        static void Main(string[] args)
        {
            numberInput number = new numberInput();
            Console.WriteLine("Please enter a whole number:");
            string numA = Console.ReadLine();
            int numAC = Convert.ToInt32(numA);
            Console.WriteLine("Please enter another whole number:");
            string numB = Console.ReadLine();
            int numBC = Convert.ToInt32(numB);
            numberInput.userNumbers(numAC, numBC);
            numberInput.userNumbers(30, 24);
            Console.ReadLine();
        }
    }
}
