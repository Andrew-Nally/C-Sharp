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
            NegativeNum newNumber = new NegativeNum();

            try
            {
                newNumber.userNumber();
            }
            catch (NegativeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("An unknown error occurred. Please try again.");
            }
            Console.ReadLine();
        }
    }
}