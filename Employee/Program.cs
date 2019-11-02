using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            List<employee> employees = new List<employee>();
            employees.Add(new employee(name:"Breck Park",id: 1));
            employees.Add(new employee(name:"Carsen Funkhauser",id: 2));
            employees.Add(new employee(name:"Kaitlyn Smith",id: 3));
            employees.Add(new employee(name:"Joe Mccraw", id:4));
            employees.Add(new employee(name:"Mary Vancleve",id: 5));
            employees.Add(new employee(name:"Joe Procacci", id:6));
            employees.Add(new employee(name:"Shane Karr", id:7));
            employees.Add(new employee(name:"Sharyl Dresser", id:8));
            employees.Add(new employee(name:"Vanessa Sanflippo", id:9));
            employees.Add(new employee(name:"Vickie Parker",id: 10));


            List<Joe> joename = new List<Joe> { };
            for (var i = 0; i < employees.Count; i++)
            {
                if ((employees[i].name).Contains("Joe"))
                {
                    joename.Add(new Joe(employees[i].name, employees[i].id));
                }
            }

            for (int x = 0; x < joename.Count; x++)
            {
                Console.WriteLine(joename[x].name +"'s ID number is: " + joename[x].id);
            }
            Console.ReadLine();


            //lambda below//
            List<ID5> IdNum = new List<ID5> { };
            List<employee> employees1 = employees.name.Where


                Console.ReadLine();
        }
    }
}
