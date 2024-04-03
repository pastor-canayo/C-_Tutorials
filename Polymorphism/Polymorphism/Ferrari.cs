using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Ferrari : SportCars
    {
        public override void PriceInformation()
        {
            Console.WriteLine("The price for a Ferrari car is 200000");
        }
    }
}
