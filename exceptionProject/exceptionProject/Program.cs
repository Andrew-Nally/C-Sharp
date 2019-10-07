using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionProject
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> ints = new List<int>() { 60, 52, 72, 48, 59, 47, 67 };
                Console.WriteLine("Please select a whole number to divide by.");
                int selection = Convert.ToInt32(Console.ReadLine());
                foreach (int number in ints)
                {
                    Console.WriteLine(number + " divided by " + selection + " equals " + (number / selection));
                }
            }

            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        Console.WriteLine("You have successfully exited the try/catch loop.");
        Console.ReadLine();
        }
    }   
}
