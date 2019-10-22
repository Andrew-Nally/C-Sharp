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
        public int Id { get; set; }

        public int employee1 { get; set; }

        public int employee2 { get; set; }

        public virtual void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName + " ID: " + Id);
        }
    }
}
