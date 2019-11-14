using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryCatchProject
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validAge = false;
            while (validAge == false) {
                Console.WriteLine("Hi. How old are you?");
                try
                {
                    int userAge = Convert.ToInt32(Console.ReadLine());
                    DateTime userYear = DateTime.Now;
                    userYear = userYear.AddYears(-userAge);
                    Console.WriteLine("\nIf you're {0} years old, you were born in or around {1}", userAge, userYear.Year);
                    Console.ReadLine();
                    validAge = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter your age in digits only.");
                }
                catch (negativeException)
            }
        }
    }
}
