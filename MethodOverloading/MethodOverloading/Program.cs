//With method overloading, multiple methods can have
//the same name with different parameters

using MethodOverloading;

Console.WriteLine("Enter the amount you get pay a month: ");
int amount = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter how many months: ");
int months = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the amount of bonus recieved: ");
int bonus = Convert.ToInt32(Console.ReadLine());

int totalYearlyWage = Utilities.CalculateYearlyWage(amount, months, bonus);

Console.WriteLine($"This is your yearly wage: {totalYearlyWage}");