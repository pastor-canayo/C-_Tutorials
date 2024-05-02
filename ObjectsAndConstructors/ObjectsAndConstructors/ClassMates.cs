//A scope in C# can be defined as a block of code
//where a variable or a function has its existence.
//It's like a house where your variables and functions live

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsAndConstructors
{
    internal class ClassMates
    {
        public string firstName;
        public string lastName;
        public int age;
        public string color;
        public string email; 

        public ClassMates(string first, string last, int ageValue, string colorPick, string mateEmail) 
        {
            firstName = first;
            lastName = last;
            age = ageValue;
            color = colorPick;
            email = mateEmail;
        }

        public void TypeOfCar()
        {
            
            Console.WriteLine("My favorite type of sport car is a Lamborgini");
        }
        public void DisplayClassMate()
        {
            
            Console.WriteLine($"\nFirst Name: {firstName}\nLast Name: {lastName}\nAge: {age}\n" +
                $"Color: {color}\nEmail: {email}");
        }
    }
}
