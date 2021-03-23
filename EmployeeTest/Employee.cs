using System;

namespace EmployeeTest
{
    public class Employee
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        private decimal salary;

        public Employee(string firstName, string lastName, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;

        }

        public decimal Salary { 
            get{
                return salary;
            }

            set{
                salary = value;
            }
            
            
        }
    }
}