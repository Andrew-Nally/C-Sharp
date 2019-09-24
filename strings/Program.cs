using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname = "Tyler";
            string lname = "Johnson";
            string address = "18365 SW Butternut St. Beaverton, OR 97078";
            string employer = "wccca";
            StringBuilder sb = new StringBuilder();

            Console.WriteLine("My name is " + fname + " " + lname + ". My address is " + address + ".");
            Console.WriteLine("I work at " + employer.ToUpper() + ".");

            sb.Append("I am attending the Tech Academy.");
            sb.Append(" The Tech Academy is in Portland, OR.");
            sb.Append(" I hope they pass this assignment :).");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
