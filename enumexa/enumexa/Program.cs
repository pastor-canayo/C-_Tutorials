
using enumexa;
using System.Xml.Linq;

//string name = SportCarsPrices.Lamborghini.ToString();
//int lamboPrice = (int)SportCarsPrices.Lamborghini;
//int cost = (int)SportCarsPrices.Lamborghini;
//double price = Price(SportCarsPrices.Lamborghini);
string ferrari = SportCarsPrices.Ferrari.ToString();
int ferrariPrice = (int)SportCarsPrices.Ferrari;
//int cost = (int)SportCarsPrices.Lamborghini;
double price= Price(SportCarsPrices.Ferrari);
//Console.WriteLine("Sport Car: " + name);
//Console.WriteLine("Price: " + lamboPrice);
//Console.WriteLine("Monthly Payments: " + price);

Console.WriteLine("Sport Car: " + ferrari);
Console.WriteLine("Price: " + ferrariPrice);
Console.WriteLine("Monthly Payments: " + price);

Console.WriteLine(SportCars.Lamborghini + " is a great and fast car" + (int)SportCars.Lamborghini);
Console.WriteLine(SportCars.Ferrari + " is a great and fast car" + (int)SportCars.Ferrari);
Console.WriteLine(SportCars.Tesla + " is a great and fast car");
Console.WriteLine(SportCars.Buggatti + " is a great and fast car");
static double Price(SportCarsPrices cost)
{
    double price = ((int)cost - 200000) / 60;
    return price;
}
