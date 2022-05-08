using System;

namespace OverRidingProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new FullTimeEmployee();
           
            emp.FirstName = "Ayaz";
            emp.LastName = "Ahmad";
            emp.email = "Ayaj123@gmail.com";
            emp.id = 101;

           emp.GetFullName();

         
        }
    }
}
