using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carInsurance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            int age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? (Enter true or false)");
            bool dui = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets have you had?");
            int tickets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qualified?");
            Console.WriteLine((age > 15 && dui == false && tickets < 3));
            Console.ReadLine();
        }
    }
}
