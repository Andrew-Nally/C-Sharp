using System;
using System.Collections.Generic;

namespace abstractProject
{
    public class Employee<T> : Person/*IQuittable*/
    {
        public List<T> Things { get; set; }
        public override void SayName()
        {
            Console.WriteLine(firstName + " " + lastName + " ID: " + Id);
            Console.ReadLine();
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