using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Lamborghini : SportCars
    {
        public override void PriceInformation()
        {
            Console.WriteLine("The price for a lamborghini car is 500000");
        }
    }
}
