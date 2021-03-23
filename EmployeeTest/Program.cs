using System;

namespace EmployeeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employeeInfo = new Employee("Adewale", "Adeyemi", 60000M);
            Employee employeeInfo2 = new Employee("Peter", "Bello", 125000M);

            Console.WriteLine($"Employee Information:\nFirst Name: {employeeInfo.FirstName}\nLast Name: {employeeInfo.LastName}\nSalary: {employeeInfo.Salary}");
            Console.WriteLine($"Employee Information:\nFirst Name: {employeeInfo2.FirstName}\nLast Name: {employeeInfo2.LastName}\nSalary: {employeeInfo2.Salary}");

            decimal newSalary = employeeInfo.Salary * (decimal)0.1;
            Console.WriteLine($"Employee Information with 10% salary increment:\nFirst Name: {employeeInfo.FirstName}\nLast Name: {employeeInfo.LastName}\nSalary: {newSalary + employeeInfo.Salary}");

            decimal newSalary2 = employeeInfo.Salary * (decimal)0.1;
            Console.WriteLine($"Employee Information with 10% salary increment:\nFirst Name: {employeeInfo2.FirstName}\nLast Name: {employeeInfo2.LastName}\nSalary: {newSalary2 + employeeInfo2.Salary}");

            
            
        }
    }
}
