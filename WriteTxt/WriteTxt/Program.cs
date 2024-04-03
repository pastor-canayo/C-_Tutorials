
Console.WriteLine("Welcome to ExpensePro");

Console.WriteLine("Select the type of expense Airplane, Car, or Uber: ");
string transportExpense = Console.ReadLine();

Console.WriteLine("How much was for the Transportation Expense?");
double amount = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the food expense: ");
double food = Convert.ToDouble(Console.ReadLine());

string path = "C:\\Users\\pasto\\Desktop\\expense.txt";

using(StreamWriter  sw = new StreamWriter(path))
{
    sw.WriteLine($"Your {transportExpense} was: {amount}");
    sw.WriteLine($"Your food expense was: {food}");
    sw.WriteLine($"Your total expense to be reimburse is: {amount + food}");
}