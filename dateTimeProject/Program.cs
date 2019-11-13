using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dateTimeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currTime = DateTime.Now;
            Console.WriteLine("It is currently: " + currTime);

            Console.WriteLine("\nEnter a whole number:");
            var userNum = Convert.ToInt32(Console.ReadLine());

            currTime = currTime.AddHours(userNum);
            Console.WriteLine("\nIn {0} hours will be: {1}.", userNum, currTime);
            Console.ReadLine();
        }
    }
}
