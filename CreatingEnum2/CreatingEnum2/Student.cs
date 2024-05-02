using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingEnum2
{
    public class Student
    {
        public string First;
        public string Last;
        public int Age;
        public CarType CarTypes;

        public Student(string first, string last, int age, CarType cars)
        {
            First = first;
            Last = last;
            Age = age;
            CarTypes = cars;
        }
        public void TypeOfCars()
        {
            if (CarTypes == CarType.Lamborghini)
            {
                Console.WriteLine("Your car is the collest and the most expensive");
            }
            else
            {
                Console.WriteLine("Your car is no as cool as the lambroghin and is cheap");
            }
           
        }
        public void DisplayInformation()
        {
            Console.WriteLine($"\nFirst Name: \t{First}\nLast Name: " +
                $"\t{Last}\nAge: \t\t{Age}\n Type Of Car: \t{CarTypes}\n");
        }
    }
}
