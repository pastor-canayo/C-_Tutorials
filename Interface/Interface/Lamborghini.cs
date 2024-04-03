using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class Lamborghini : ISportCars
    {
        public void MilesPerHour()
        {
            Console.WriteLine("300000 miles per hour");
        }

        public void PriceInformation()
        {
            Console.WriteLine("The price for a lamborghini is 500000");
        }
    }
}
