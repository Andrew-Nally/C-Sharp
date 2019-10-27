using System;

namespace abstractProject
{
    public class Employee<T> : Person/*IQuittable*/
    {
        public override void SayName()
        {
            Console.WriteLine(firstName + " " + lastName + " ID: " + Id);
            Console.ReadLine();
        }

        public void List(string things) {

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
    }
}
