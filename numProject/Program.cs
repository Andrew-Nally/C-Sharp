using System;

namespace numProject
{
    class Program
    {
        static void Main(string[] args)
        {
            userNumbers number = new userNumbers();
            userNumbers.InputNumbers(12);
            userNumbers.DecimalNum(35.6);
            userNumbers.StringNum("4");
            Console.ReadLine();
        }
    }
}
