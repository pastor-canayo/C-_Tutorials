using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Lamborghini lamborghini = new Lamborghini();
            Ferrari ferrari = new Ferrari();
            ferrari.Price();
            lamborghini.Price();

            Console.WriteLine(lamborghini.color + " " + lamborghini.model);
            Console.WriteLine(ferrari.color + " " + ferrari.modelFerrari);
        }
    }
}
