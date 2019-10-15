using System;

namespace opitonalInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Number nums = new Number();
            Console.WriteLine("Pick a number:");
            int userValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick another number--optional");
            var userValue2IsValid = int.TryParse(Console.ReadLine(), out int userValue2);

            int result;
            if (userValue2IsValid)
            {
                result = Number.Nums(userValue, userValue2);
            }
            else
            {
                result = Number.Nums(userValue);
            }

            Console.WriteLine("Your total is: " + result);
            Console.ReadLine();
        }
    }
}
