using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingEnum
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
        public void TypeOfCar()
        {
            if(CarTypes == CarType.Lamborghini)
            {
                Console.WriteLine("Your car is the coolest and the most expensive");
            }
            else
            {
                Console.WriteLine("Your car is not as cool as the lamborghini");
            }
        }
        public void DisplayInformation()
        {
            Console.WriteLine($"\nFirst Name: \t{First}\nLast Name: " +
                $"\t{Last}\nAge: \t\t{Age}\n Type Of Car: \t{CarTypes}\n");
        }
    }

    
   
}
