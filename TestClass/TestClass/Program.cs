using System;

namespace TestClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating an employee");
            Console.WriteLine("-----------------\n");


            Employee employee = new Employee("Pastor", "Canayo", "bethany@snowball.be", new DateTime(1979, 1, 16), 40, 500000);
            Employee employee2 = new Employee("Angelina", "Smith", "Angelina@snowball.be", new DateTime(1979, 1, 16), 40, 500000);

            string employeeAsJson = employee.ConvertToJson();
            Console.WriteLine(employeeAsJson);
            //employee.DisplayEmployyeInformation();
            //employee2.DisplayEmployyeInformation();
        }
    }
}
