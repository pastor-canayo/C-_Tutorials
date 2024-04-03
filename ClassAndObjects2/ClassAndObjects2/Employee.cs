using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjects2
{
    public class Employee
    {
        public string Name;
        public string Position;
        public int Age;
        public int Salary;

        public void Information()
        {
            Console.WriteLine("I am the best employee ever");
        }
        public Employee(string fullName, string workPosition, int yearOld, int anualSalary)
        {
            Name = fullName;
            Position = workPosition;
            Age = yearOld;
            Salary = anualSalary;
        }
    }
}
