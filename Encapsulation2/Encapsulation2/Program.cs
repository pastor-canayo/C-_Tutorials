using System;

namespace Encapsulation2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employees employees = new Employees();
            employees.EmployeeName = "Mike Pastor";
            employees.EmployeeAge = 30;


            Console.WriteLine("Employee Name: " + employees.EmployeeName);
            Console.WriteLine("Employee Age: " + employees.EmployeeAge);
        }
    }
}
