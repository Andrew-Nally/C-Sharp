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
            employee.firstName1 = "Tyler";
            employee.lastName1 = "Johnson";
            employee.Id1 = 2;
            employee.SayName();

            IQuittable employ = new Employee();
            employ.Quit();
        }
    }
}
