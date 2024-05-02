using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingClass
{
    internal class Employee
    {
        public string FirstName;
        public string LastName;
        public string Email;

        public int NumberOfHoursWorked;
        public double Wage;
        public double HourlyRate;
        const int minimalHoursWorkedUnit = 1;


        public DateTime Birthday;
        //public Employee(string first, string last, string em, DateTime bd) : this(first, last, em, bd, 0)
        //{

        //}
        public Employee(string first, string last, string em, DateTime bd, double rate) 
        {
            FirstName = first;
            LastName = last;
            Email = em;
            Birthday = bd;
            HourlyRate = rate;
        }
        public void PerformWork()
        {
            //NumberOfHoursWorked++;
            PerformWork(minimalHoursWorkedUnit);
            //Console.WriteLine($"{FirstName}{LastName} has worked for {NumberOfHoursWorked} hours(s)!");

        }
        public void PerformWork(int numberOfHours)
        {
            NumberOfHoursWorked += numberOfHours;
            Console.WriteLine($"{FirstName}{LastName} has worked for {NumberOfHoursWorked} hours(s)!");
        }
        public double RecieveWage(bool resetHours = true)
        {
            Wage = NumberOfHoursWorked * HourlyRate;
            Console.WriteLine($"{FirstName}{LastName} has recieved a wage of {Wage} for {NumberOfHoursWorked} hour(s) of work");

            if (resetHours)
            {
                NumberOfHoursWorked = 0;
            }
            return Wage;
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFirst Name: \t{FirstName}\nLast Name: " +
                $"\t{LastName}\nEmail: \t\t{Email}\n Birthday: \t{Birthday.ToShortDateString()}\n");
        }
    }
}
