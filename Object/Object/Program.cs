
using Object;

ClassMate classMate = new ClassMate("Pastor", "Canayo", 25, "Green", "pastor@gmail.com");

classMate.firstName = "Pedro";

classMate.DisplayClassMate();
classMate.TypeOfCar();



Console.WriteLine("\nCreating another object");
Console.WriteLine("=======================\n");

ClassMate classMate2 = new ClassMate("Johnny", "Smith", 25, "Red", "Jonny@gmail.com");



classMate2.DisplayClassMate();
classMate2.TypeOfCar();

