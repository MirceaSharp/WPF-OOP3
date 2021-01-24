using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_OOP3
{
    class Employee
    {

        private string _firstName;
        private string _lastName;
        private double _salary;


        public string FirstName { get; set; }
        public string LastName { get; set; }

        public double Salary { get; set; }
       



        public Employee(string firstName, string lastName, double salary)
        {

            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
            
        }
        public override string ToString()
        {
            return FirstName.PadRight(15) + LastName.PadRight(15) + Salary.ToString("0.00").PadLeft(8) + " €";
        }


    }
}
