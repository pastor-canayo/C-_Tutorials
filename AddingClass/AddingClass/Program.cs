// Adding a class for our method 
// Adding a helper file
// Moving the method
// invoking the method again

using AddingClass;

Console.WriteLine("Enter the amount you get pay a month: ");
int amount = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter how many months: ");
int months = Convert.ToInt32(Console.ReadLine());



int totalYearlyWage = Utilities.CalculateYearlyWage(amount, months);

Console.WriteLine(totalYearlyWage);

