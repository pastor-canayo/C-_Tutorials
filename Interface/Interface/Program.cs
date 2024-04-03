using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Lamborghini lamborghini = new Lamborghini();
            Ferrari ferrari = new Ferrari();
            lamborghini.MilesPerHour();
            lamborghini.PriceInformation();
            ferrari.MilesPerHour();
            ferrari.PriceInformation();


        }
    }
}
