using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Classes
{
    public class SalesPerson : Employee
    {
        public SalesPerson(string firstName, string lastName) 
        { 
            FirstName = firstName;
            LastName = lastName;
            Salary = 500;
            Role = Enums.Role.Sales;
            SuccessSaleRevenue = 0;
        }

        private double SuccessSaleRevenue { get; set; }

        public double AddSuccessRevenue(double number)
        {
            SuccessSaleRevenue += number;
            return SuccessSaleRevenue;
        }

        public override void GetSalary()
        {
           if (SuccessSaleRevenue <= 2000) Console.WriteLine($"Salary plus bonus for {FirstName} {LastName} is: {Salary + 500}");
           else if (SuccessSaleRevenue > 2000 && SuccessSaleRevenue <= 5000) Console.WriteLine($"Salary plus bonus for {FirstName} {LastName} is: {Salary + 1000}");
           else if (SuccessSaleRevenue > 5000) Console.WriteLine($"Salary plus bonus for {FirstName} {LastName} is: {Salary + 1500}");
        } 
       
        }
    }


