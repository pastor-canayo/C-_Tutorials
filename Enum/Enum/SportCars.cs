using System;
using System.Collections.Generic;
using System.Text;

namespace Enum
{
    public class SportCars
    {
        public SportCarsType sportCarsType;

        public void ImplementationLamborghini()
        {
            if (sportCarsType == SportCarsType.Lamborghini)
            {
                Console.WriteLine("Lamborghini is the best car you can ever have");
            }
           
           
           
        }
        public void ImplementationFerrari()
        {
            if (sportCarsType == SportCarsType.Ferrari)
            {
                Console.WriteLine("Ferrari is the best car you can ever have and it goes 200 miles");
            }
        }
        public void ImplementationBuggatti()
        {
            if (sportCarsType == SportCarsType.Buggatti)
            {
                Console.WriteLine("Buggatti is the best car you can ever have and it goes 200 miles");
            }
        }
        public void ImplementationTesla()
        {
            if (sportCarsType == SportCarsType.Tesla)
            {
                Console.WriteLine("Tesla is the best car you can ever have and it goes 200 miles");
            }
        }
    }
}
