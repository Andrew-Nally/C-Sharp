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
            Employee<T> employee = new Employee<T>();
            List<string> Things = new List<string>() { "Tyler", "Kinsey", "Patty" };

            Things.ForEach(Thing => Console.WriteLine(Thing));

            IList<int> ThingsInt = new List<int>() { 10, 20, 30, 40 };

            foreach (var Thing in ThingsInt)
                Console.WriteLine(Thing);

            Console.ReadLine();

            //Employee employee = new Employee();
            //Employee employee2 = new Employee();

            //employee.firstName = "Sample";
            //employee.lastName = "Student";
            //employee.Id = 1;
            //employee.SayName();
            //employee2.firstName = "Tyler";
            //employee2.lastName = "Johnson";
            //employee2.Id = 2;
            //employee2.SayName();
            //bool employeesAreTheSame = (employee == employee2);
            //if (employeesAreTheSame == true) {
            //    Console.WriteLine("You can't have the same ID for two people.\n");
            //}
            //else
            //{
            //    Console.WriteLine("These ID numbers are unique\n");
            //}

            //IQuittable employ = new Employee();
            //employ.Quit();
        }
    }
}
