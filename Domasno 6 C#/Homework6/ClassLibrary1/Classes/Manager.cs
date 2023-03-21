using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Classes
{
    public class Manager : Employee
    {
        public Manager(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
            Role = Enums.Role.Manager;
            Salary = 500;
            Bonus = 0;
        }

        private double Bonus { get; set; }

        public double AddBonus(double number)
        {
            Bonus += number;
            return Bonus;
        }

        public override void GetSalary()
        {
            Console.WriteLine($"Salary after bonus for: {FirstName} {LastName} is {Salary + Bonus} $");
        }

    }
}
