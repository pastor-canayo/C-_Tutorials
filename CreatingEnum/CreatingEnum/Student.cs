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
        public string Email;
        public int NumberOfHoursWorked;

        public CarType CarTypes;

        public Student(string first, string last, int age, string email, CarType cars)
        {
            First = first;
            Last = last;
            Age = age;
            Email = email;
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
        public void PerformWork(int numberOfHours)
        {
            NumberOfHoursWorked += numberOfHours;
            Console.WriteLine($"{First} {Last} has worked for {NumberOfHoursWorked} hours to afford the car");
        }
        public void DisplayInformation()
        {
            Console.WriteLine($"\nFirst Name: \t{First}\nLast Name: " +
                $"\t{Last}\nAge: \t\t{Age}\nEmail: \t\t{Email}\nType Of Car: \t{CarTypes}\n");
        }
    }

    
   
}
