using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    internal class ClassMate
    {
        public string firstName;
        public string lastName;
        public int age;
        public string color;
        public string email;

        public ClassMate(string first, string last, int mateAge, string colorPick, string mateEmail) 
        {
            firstName = first;
            lastName = last;
            age = mateAge;
            color = colorPick;
            email = mateEmail;
        }
        public void TypeOfCar()
        {
            Console.WriteLine("My favorite type of car is Lamborghini");
        }
        public void DisplayClassMate()
        {
            Console.WriteLine($"\nFirst Name: {firstName}\nLast Name: {lastName}\nAge: {age}\n" +
                $"Color: {color}\nEmail: {email}");
        }

    }
}
