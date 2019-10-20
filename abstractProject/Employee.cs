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
        public List<Person> Ids { get; set; }
        public override void SayName()
        {
            Console.WriteLine(firstName + " " + lastName);
            Console.ReadLine();
        }

        public static Employee operator +(Person person, Employee employee)
        {
            employee.Ids.Add(person);
            return employee;
        }

            public void Quit()
        {
            Console.WriteLine("Are you sure you want to quit?");
            Console.ReadLine();
        }
    }
}
