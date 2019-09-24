using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            bool correctName = false;

            while (correctName == false)
            {
                Console.WriteLine("What is your username?");
                string username = Console.ReadLine();

                switch (username)
                {
                    case "tjohnson":
                        Console.WriteLine("Welcome Tyler");
                        correctName = true;
                        break;

                    case "bzwahlen":
                        Console.WriteLine("Welcome Brad");
                        correctName = true;
                        break;

                    default:
                        Console.WriteLine("Incorrect username. Please try again.");
                        break;
                }
            }
            bool password = false;
            do
            {
                Console.WriteLine("What is your password?");
                string userPassword = Console.ReadLine();

                switch (userPassword)
                {
                    case "Password1":
                        Console.Write("You are logged in.");
                        password = true;
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Incorrect password. Please try again.");
                        break;
                }
            } while (password == false);
        }
    }
}
