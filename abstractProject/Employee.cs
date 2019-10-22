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
            Console.WriteLine(firstName + " " + lastName + " ID: " + Id);
            Console.ReadLine();
        }

        public override void SayName1()
        {
            Console.WriteLine(firstName1 + " " + lastName1 + " ID: " + Id1);
            Console.ReadLine();
        }

        public static bool operator ==(Employee employee, Employee employee1)
        {
            if (employee.Id == employee1.Id1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Employee employee, Employee employee1)
        {
            if (employee.Id == employee1.Id1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Quit()
        {
            Console.WriteLine("Are you sure you want to quit?");
            Console.ReadLine();
        }
    }
}
