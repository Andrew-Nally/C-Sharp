using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Employee employee2 = new Employee();

            employee.firstName = "Sample";
            employee.lastName = "Student";
            employee.Id = 1;
            employee.SayName();
            employee2.firstName = "Tyler";
            employee2.lastName = "Johnson";
            employee2.Id = 2;
            employee2.SayName();
            bool employeesAreTheSame = (employee == employee2);
            if (employeesAreTheSame == true) {
                Console.WriteLine("You can't have the same ID for two people.\n");
            }
            else
            {
                Console.WriteLine("These ID numbers are unique\n");
            }

            Console.WriteLine("Alan! You're my freaking hero!\n");
            IQuittable employ = new Employee();
            employ.Quit();
        }
    }
}
