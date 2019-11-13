using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace logProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number. Any number");
            string numChoice = Console.ReadLine();

            File.WriteAllText(@"C:\Users\Tyler\Desktop\Test\test.txt", numChoice);
            string text = File.ReadAllText(@"C:\Users\Tyler\Desktop\Test\test.txt");
            Console.WriteLine("Contents of test.txt = {0}", text);
            Console.ReadLine();
        }
    }
}
