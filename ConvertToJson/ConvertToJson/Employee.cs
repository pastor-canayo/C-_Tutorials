using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConvertToJson
{
    public class Employee
    {
        public string FirstName;
        public string LastName;
        public string Email;
        public DateTime Birthday;
        public int Salary;

        public Employee(string first, string last, string em, DateTime bd, int payment)
        {
            FirstName = first;
            LastName = last;
            Email = em;
            Birthday = bd;
            Salary = payment;
        }
        public string ConvertToJson()
        {
            string json = JsonConvert.SerializeObject(this);
            return json;
        }
        public void DisplayEmployeeInformation()
        {
            Console.WriteLine($"\nFirst name: \t{FirstName}\nLast name: \t{LastName}\nEmail: \t\t{Email}" +
               $"Birthday: \t{Birthday.ToShortDateString()}\nSalary: \t{Salary}");
        }
    }
}
