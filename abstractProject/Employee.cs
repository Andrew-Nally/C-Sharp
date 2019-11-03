using System;
using System.Collections.Generic;

namespace abstractProject
{
    public class Employee : Person/*IQuittable*/
    {
        public string Things { get; set; }
        public string Emps { get; set; }
        public override void SayName()
        {
            Console.WriteLine(firstName + " " + lastName + " ID: " + Id);
            Console.ReadLine();
        }

        public string ToList()

        {

            return string.Format("Fruit: {0}, weight: {1}, quantity: {2}", firstName, lastName, Id);

        }
    }
}


    //public static bool operator ==(employee<bool> employee, employee<bool> employee2)
    //{
    //    if (employee.id == employee2.id)
    //    {
    //        return true;
    //    }
    //    else
    //    {
    //        return false;
    //    }
    //}

    //public static bool operator !=(employee<bool> employee, employee<bool> employee2)
    //{
    //    if (employee.id != employee2.id)
    //    {
    //        return false;
    //    }
    //    else
    //    {
    //        return true;
    //    }
    //}

    //public void quit()
    //{
    //    console.writeline("are you sure you want to quit?");
    //    console.readline();
    //}