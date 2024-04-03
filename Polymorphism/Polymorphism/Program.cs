using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            SportCars sportCars = new SportCars();
            SportCars lamborghini = new Lamborghini();
            SportCars ferrari = new Ferrari();

            sportCars.PriceInformation();
            lamborghini.PriceInformation();
            ferrari.PriceInformation();
        }
    }
}
