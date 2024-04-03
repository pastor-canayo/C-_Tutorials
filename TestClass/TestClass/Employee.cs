﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestClass
{
    public class Employee
    {
        public string FirstName;
        public string LastName;
        public string Email;
        public DateTime Birthday;
        public int Age;
        public int Salary;

        public void Information()
        {
            Console.WriteLine("I am a star employee");
        }
        public Employee(string first, string last, string em, DateTime bd, int edad, int payment)
        {
            FirstName = first;
            LastName = last;
            Email = em;
            Birthday = bd;
            Age = edad;
            Salary = payment;


        }
        public string ConvertToJson()
        {
            string json = JsonConvert.SerializeObject(this);
            return json;
        }
        public void DisplayEmployyeInformation()
        {
            Console.WriteLine($"\nFirst name: \t{FirstName}\nLast name: \t{LastName}\nEmail: \t\t{Email}" +
                $"Birthday: \t{Birthday.ToShortDateString()}\nAge: \t\t{Age}\nSalary: \t{Salary}");
        }
    }
}
