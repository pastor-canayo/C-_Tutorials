// Magic 8 ball asking question

using Cube2;

Console.WriteLine("Please enter your question for the magic ball");
Console.ReadLine();

var randomList = MagibBall.GenerateList();
Console.WriteLine(randomList);