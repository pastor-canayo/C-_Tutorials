using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class Ferrari : ISportCars
    {
        public void MilesPerHour()
        {
            Console.WriteLine("200000 miles per hour");
        }

        public void PriceInformation()
        {
            Console.WriteLine("The price for a Ferrari is 300000");
        }
    }
}
