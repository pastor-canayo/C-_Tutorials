using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your best sport cars: ");
            string carType = Console.ReadLine();
            SportCars sportCars = new SportCars();

            if (carType == "Lamborghini")
            {
                
                sportCars.ImplementationLamborghini();
            }
            else if(carType == "Ferrari")
            {
                
                sportCars.ImplementationFerrari();
            }
            else if (carType == "Buggatti")
            {
                
                sportCars.ImplementationBuggatti();
            }
            else if (carType == "Tesla")
            {
                
                sportCars.ImplementationTesla();
            }
            else
            {
                Console.WriteLine("No a car in the collection");
            }
        }
    }
}
