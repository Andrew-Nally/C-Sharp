using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractProject
{
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public string firstName1 { get; set; }
        public string lastName1 { get; set; }

        public virtual void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
            Console.WriteLine("Name: " + firstName1 + " " + lastName1);
        }
    }
}
