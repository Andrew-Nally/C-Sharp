using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractProject
{
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }
        public int Id1 { get; set; }
        public override void SayName()
        {
            Console.WriteLine(firstName + " " + lastName);
            Console.ReadLine();
        }

        public static bool operator ==(Employee employee, Employee employee1)
        {
            if (employee.Id == employee1.Id1)
                return true;
            else
                return false;
        }

        public static bool operator !=(Employee employee, Employee employee1)
        {
            if (employee.Id != employee1.Id1)
                return false;
            else
                return true;
        }

        public void Quit()
        {
            Console.WriteLine("Are you sure you want to quit?");
            Console.ReadLine();
        }
    }
}
