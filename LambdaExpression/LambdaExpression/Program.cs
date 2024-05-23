//C# Lambda Expression is a short block of code that accepts parameters and returns a value.
//It is defined as an anonymous function (function without a name).
//Here, "num" is an input parameter and num * 7 is a return value. The lambda expression
//does not execute on its own. Instead, we use it inside other methods or variables.
// num => num * 7
// LINQ Query 

List<int> numbers = new List<int>() { 36, 71, 12, 15, 29, 18, 27 };

var square = numbers.Select(x => x * x);

foreach (var number in square)
{
    Console.WriteLine(number);
}

Console.WriteLine("\n=========================\n");

//We have a list of people below and we want to only extract the ids.
//Here, we can use the Select method and the lambda expression person => person.Id.

var people = new[]
{
    new{Id = 100, Name = "Jennifer", Age = 21},
    new{Id = 102, Name = "Pedro", Age = 35},
    new{Id = 104, Name = "Johnathan", Age = 45}
};
var selection = people.Select(x => x.Age);

foreach (var number2 in selection)
{
    Console.WriteLine(number2);
}
