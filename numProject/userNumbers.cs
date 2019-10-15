using System;
using System.Collections.Generic;
using System.Text;

namespace numProject
{
    class userNumbers
    {
        public static void InputNumbers(int i)
        {
            int MultiplyI = i * i;
            Console.WriteLine(i + " multiplied by itself is: " + MultiplyI);
        }

        public static void DecimalNum(double i)
        {
            double addI = i + 34.75;
            int decNum = Convert.ToInt32(addI);
            Console.WriteLine(i + " added to 34.75, converted to an integer, is: " + decNum);
        }

        public static void StringNum(string i)
        {
            int stringConvert = Convert.ToInt32(i);
            int numString = stringConvert / 2;
            Console.WriteLine(i + " divided by 2 is: " + numString);
        }
    }
}
