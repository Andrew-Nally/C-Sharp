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

            employee.firstName = "Sample";
            employee.lastName = "Student";
            employee.Id = 1;
            employee.SayName();
            employee.firstName = "Tyler";
            employee.lastName = "Johnson";
            employee.Id = 2;
            employee.SayName();
            bool employeesAreTheSame = (employee.employee1 == employee.employee2);
            Console.WriteLine(employeesAreTheSame);



            IQuittable employ = new Employee();
            employ.Quit();
            Console.ReadLine();
        }
    }
}
