using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CreatingClassesAndObjects
{
    internal class Employee
    {
        public string FirstName;
        public string LastName;
        public string Email;

        public int NumberOfHoursWorked;
        public double Wage;
        public double HourlyRate;
        const int minimalHoursWorked = 1;
        public DateTime Birthday;
        public EmployeeType employeeType;

        public Employee(string first, string last, string em, DateTime bd, double rate, EmployeeType empType)
        {
            FirstName = first;
            LastName = last;
            Email = em;
            Birthday = bd;
            HourlyRate = rate;
            employeeType = empType;
        }
        public void PerformWork()
        {
            PerformWork(minimalHoursWorked);
        }
        public void PerformWork(int numberOfHours)
        {
            NumberOfHoursWorked += numberOfHours;
            Console.WriteLine($"{FirstName}{LastName} has worked for {NumberOfHoursWorked} hour(s)!");
        }
        public double RecieveWage(bool resetHours = true)
        {
            //Wage = NumberOfHoursWorked * HourlyRate;
            //Console.WriteLine($"{FirstName}{LastName} has received a wage of {Wage}" +
            //    $" for {NumberOfHoursWorked} hour(s) of work");
            //if (resetHours)
            //{
            //    NumberOfHoursWorked = 0;
            //}
            //return Wage;

            if (employeeType == EmployeeType.Manager)
            {
                Console.WriteLine($"An extra was added to the wage since {FirstName}" +
                    $"is a manager");
                Wage = NumberOfHoursWorked * HourlyRate * 1.25;
            }
            else
            {
                Wage = NumberOfHoursWorked * HourlyRate;
            }
            Console.WriteLine($"{FirstName}{LastName} has received a wage of {Wage}" +
                $" for {NumberOfHoursWorked} hour(s) of work");
            if (resetHours)
            {
                NumberOfHoursWorked = 0;
            }
            return Wage;

        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFirst Name: \t\t{FirstName}\nLast Name: " +
                $"\t{LastName}\nEmail \t\t{Email}\n Birthday: \t{Birthday.ToShortDateString()}\n" );
        }
    }
}
