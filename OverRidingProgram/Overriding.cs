using System;
using System.Collections.Generic;
using System.Text;

namespace OverRidingProgram
{
    public class Employee
    {
         public int id { get;set;}
         public string FirstName { get;set;}
        public string LastName { get;set;}
         public string email { get;set;}

        public virtual void GetFullName()
        {
            Console.WriteLine(FirstName+" "+LastName);
        }
    }
    public class FullTimeEmployee : Employee

    {
        public override void GetFullName()
        {
            Console.WriteLine(id+" -- "+FirstName+" "+LastName+" -- "+email);
        }
      
    }

    
}
