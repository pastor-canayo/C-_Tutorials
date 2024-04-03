using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers2
{
    class Modifiers2
    {
        private string _name;
        private string _description;
        private string _color;

        public int Edad(int year, int age)
        {
            return year - age;
        }
        static void Main(string[] args)
        {
            Modifiers2 mod = new Modifiers2();
            mod._name = "Pastor";
            mod._description = "is a cool guy";
            mod._color = "green";

            Console.WriteLine($"{mod._name} {mod._description} " +
                $" and his favorite color is {mod._color} and he was born in the year {mod.Edad(2024, 20)}");
        }
    }
}
