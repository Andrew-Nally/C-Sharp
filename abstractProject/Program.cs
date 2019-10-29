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
            Employee<string> employee = new Employee<string>();
            Employee<int> employeeInt = new Employee<int>();
            employee.Things = new List<string>() { "Tyler", "Kinsey", "Patty" };
            employeeInt.Things = new List<int>() { 50, 60, 70, 80};

            foreach (var thing in employee.Things)
                Console.WriteLine(thing);

            foreach (var num in employeeInt.Things)
                Console.WriteLine(num);


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
