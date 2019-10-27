using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumProject
{
    class Program
    {
        public enum Days
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a weekday in the following format: Monday, Tuesday, etc.");
            string value = Console.ReadLine();

            Days day;

            try
            {
                day = (Days)Enum.Parse(typeof(Days), value);
                Console.WriteLine("You selected: " + day);
                Console.ReadLine();

            }
            catch (Exception ex)
            {
                // The conversion failed.
                Console.WriteLine("Please enter an actual day of the week.");
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
