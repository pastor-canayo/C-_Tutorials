//List<T> is a class that contains multiple objects of
//the same data type that can be accessed using an index.
//For example,

List<int> number = new List<int>() {1,2,3,4 };

for  (int i = 0; i < number.Count; i++)
{
    Console.WriteLine("These are the elements: " + number[i]);
}

Console.WriteLine("\n=========================\n");

List<string> name = new List<string>() { "Pastor", "Pedro", "Alexandria", "Johnny" };

for (int i = 0; i < name.Count; i++)
{
    Console.WriteLine("These are the elements names: " + name[i]);
}

Console.WriteLine("\n=========================\n");

List<string> countries = new List<string>() { "Peru" };

countries.Add("USA");
countries.Add("Germany");
countries.Add("Italy");
countries.Add("Ecuador");
countries.Add("Colombia");

for (int i = 0; i < countries.Count; i++)
{
    Console.WriteLine(countries[i]);
}

Console.WriteLine("\n=========================\n");

List<string> programming = new List<string>() { "Python", "Java", "HTML", "CSharp" };
programming.Insert(2, "Ruby");

for (int i = 0; i < programming.Count; i++)
{
    Console.WriteLine(programming[i]);
}

Console.WriteLine("\n=========================\n");

List<string> cars = new List<string>() { "Toyota", "Tesla", "Suzuki", "Ferrari" };
cars.Remove("Suzuki");

for (int i = 0; i < cars.Count; i++)
{
    Console.WriteLine(cars[i]);
}

Console.WriteLine("\n=========================\n");

List<string> cars2 = new List<string>() { "Toyota", "Tesla", "Suzuki", "Ferrari" };
cars2.RemoveAt(1);
for (int i = 0; i < cars2.Count; i++)
{
    Console.WriteLine(cars2[i]);
}