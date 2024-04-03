using System;

namespace Encapsulation3
{
    //Encapsulation
    //Encapsulation is defined as the wrapping up of data
    //and information under a single unit. It is the mechanism
    //that binds together the data and the functions that manipulate
    //them. In a different way, encapsulation is a protective shield
    //that prevents the data from being accessed by the code outside
    //this shield.
    class Program
    {
        static void Main(string[] args)
        {
            Employees employee = new Employees();
            employee.EmployeeName = "Mike Smith";
            employee.EmployeeAge = 45;
            employee.EmployeeId = 1234;

            Console.WriteLine("Employee Name: " + employee.EmployeeName);
            Console.WriteLine("Employee Age: " + employee.EmployeeAge);
            Console.WriteLine("Employee Id: " + employee.EmployeeId);
        }
    }
}
