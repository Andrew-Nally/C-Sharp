using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryCatchProject
{
    public class NegativeNum
    {
        public void userNumber()
        {
            Console.WriteLine("Hi. How old are you?");
            int userAge = Convert.ToInt32(Console.ReadLine());
            if (userAge < 0)
            {
                throw new NegativeException("You cannot enter a negative number.");
            }
            else if (userAge == 0)
            {
                throw new NegativeException("You cannot be zero years old");
            }
            DateTime userYear = DateTime.Now;
            userYear = userYear.AddYears(-userAge);
            Console.WriteLine("\nIf you're {0} years old, you were born in or around {1}", userAge, userYear.Year);
        }
    }
}
