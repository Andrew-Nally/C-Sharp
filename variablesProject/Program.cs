using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variablesProject
{
    public class VariablesProject
    {
        static void Main(string[] args)
        {
            const string schoolName = "The Tech Academy";
            var userName = "Tyler";
            Console.WriteLine("{0} is taking classes at {1}.", userName, schoolName);

            Computer newComputer = new Computer("Desktop");
            Console.WriteLine(newComputer.Type + " " + newComputer.Monitor + " " + newComputer.Cores);
            Console.ReadLine();
        }
    }
}
