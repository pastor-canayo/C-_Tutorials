// enums
using enumTu;

//Console.WriteLine("This is a nice " + SportCars.Lamborghini + " Sport car and is in position " + (int)SportCars.Lamborghini
//    + "and the price is: " + (int)SportCarsPrice.Lamborghini);
//Console.WriteLine("This is a nice " + SportCars.Ferrari + " Sport car and is in position " + (int)SportCars.Ferrari);
//Console.WriteLine("This is a nice " + SportCars.Tesla + " Sport car and is in position " + (int)SportCars.Tesla);
//Console.WriteLine("This is a nice " + SportCars.Buggatti + " Sport car and is in position " + (int)SportCars.Buggatti);
//string name = SportCars.Lamborghini.ToString();
//int lamborghini = (int)SportCarsPrice.Lamborghini;
//double price = Price(SportCarsPrice.Lamborghini);

string name = SportCars.Ferrari.ToString();
int ferrari = (int)SportCarsPrice.Ferrari;
double price = Price(SportCarsPrice.Ferrari);

Console.WriteLine("Sport Car: " + name);    
Console.WriteLine("Price: " + ferrari);   
Console.WriteLine("Monthly Payment: " +  price);

static double Price(SportCarsPrice cost)
{
    double price = ((int)cost - 200000) / 60;
    return price;
}
