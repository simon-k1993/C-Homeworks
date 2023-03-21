using ClassLibrary1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Classes
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Role Role { get; set; }

        protected double Salary { get; set; }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"First name: {FirstName} Last name: {LastName} Salary: {Salary}");
        }

        public virtual void GetSalary()
        {
            Console.Write($"Salary: {Salary}");
        }
    }
}
