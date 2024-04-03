using System;

namespace ConvertToJson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating an employee");
            Console.WriteLine("--------------------\n");

            Employee employee = new Employee("Pastor", "Canayo", "pastor@yahoo.com", new DateTime(1979, 1, 16), 300000);

            //employee.DisplayEmployeeInformation();

            string employeeAsJson = employee.ConvertToJson();
            Console.WriteLine(employeeAsJson);
        }
    }
}
