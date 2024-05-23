
List<int> numbers = new List<int>() {36,71,12,15,29,18,27 };
 
var square = numbers.Select(x => x * x);

Console.WriteLine("Square: ");

foreach (var number in square)
{
    Console.WriteLine(number);
}

Console.WriteLine("\n=========================\n");

var people = new[]
{
    new{Id = 6000, Name = "Jennifer", Age = 21},
    new{Id = 6001, Name = "Pedro", Age = 22},
    new{Id = 6003, Name = "John", Age = 23},
};

var ids = people.Select(x => x.Age);
foreach (var number2 in ids)
{
    Console.WriteLine(number2);
}