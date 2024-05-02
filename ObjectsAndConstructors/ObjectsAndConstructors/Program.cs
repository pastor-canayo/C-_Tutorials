//The Instance of a class is object
//Object are often referred as a instances
//Creating an object is the same as saying an instance

using ObjectsAndConstructors;

ClassMates classMates = new ClassMates("Pastor", "Canayo", 25, "Green", "pastor@gmail.com");
classMates.firstName = "Pedro";
classMates.DisplayClassMate();
classMates.TypeOfCar();

Console.WriteLine("\nCreating another object");
Console.WriteLine("=======================\n");

ClassMates classMates2 = new ClassMates("Huampa", "Surita", 35, "Red", "huampa@gmail.com");

classMates2.DisplayClassMate();
classMates2.TypeOfCar();


