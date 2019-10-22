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

        public static bool operator ==(Employee employee, Employee employee2)
        {
            if (employee.Id == employee2.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Employee employee, Employee employee2)
        {
            if (employee.Id != employee2.Id)
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
