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
            List<Employee> employeeLst = new List<Employee>();
            employeeLst.Add(new Employee() { firstName = "Tyler", lastName = "Johnson", Id = 1 });
            employeeLst.Add(new Employee() { firstName = "Nora", lastName = "Hicks", Id = 2 });
            employeeLst.Add(new Employee() { firstName = "Joe", lastName = "Freeman", Id = 3 });
            employeeLst.Add(new Employee() { firstName = "Ashley", lastName = "Eichenberger", Id = 4 });
            employeeLst.Add(new Employee() { firstName = "Joe", lastName = "Raichel", Id = 5 });
            employeeLst.Add(new Employee() { firstName = "Jeff", lastName = "Golden", Id = 6 });
            employeeLst.Add(new Employee() { firstName = "John", lastName = "Mason", Id = 7 });
            employeeLst.Add(new Employee() { firstName = "Jon", lastName = "Nolan", Id = 8 });
            employeeLst.Add(new Employee() { firstName = "Joy", lastName = "Sifferle", Id = 9 });
            employeeLst.Add(new Employee() { firstName = "Katie", lastName = "Fischer", Id = 10 });

            List<Employee> joeList = new List<Employee>();

            Console.Write("Employees named Joe:\n");
            for (int i = 0; i < employeeLst.Count; i++)
                if (employeeLst[i].firstName == "Joe")
                {
                    joeList.Add(new Employee() { firstName = employeeLst[i].firstName, lastName = employeeLst[i].lastName, Id = employeeLst[i].Id });
                }

            for (int j = 0; j < joeList.Count; j++)
                Console.WriteLine(joeList[j].firstName + " " + joeList[j].lastName + " ID: " + joeList[j].Id);

            List<Employee> idList = employeeLst.Where(x => x.Id > 5).ToList();

            Console.WriteLine("\nEmployees with an ID greater than 5:");
            for (int a = 0; a < idList.Count; a++)
                Console.WriteLine(idList[a].firstName + " " + idList[a].lastName + " ID: " + idList[a].Id);

            Console.ReadLine();


            //Employee<string> employee = new Employee<string>();
            //Employee<int> employeeInt = new Employee<int>();
            //employee.Things = new List<string>() { "Tyler", "Kinsey", "Patty" };
            //employeeInt.Things = new List<int>() { 50, 60, 70, 80};

            //foreach (var thing in employee.Things)
            //    Console.WriteLine(thing);

            //foreach (var num in employeeInt.Things)
            //    Console.WriteLine(num);




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
