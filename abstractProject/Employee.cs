using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractProject
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine(firstName + " " + lastName);
            Console.ReadLine();
        }

        public void Quit()
        {
            Console.WriteLine("Are you sure you want to quit?");
            Console.ReadLine();
        }
    }
}
