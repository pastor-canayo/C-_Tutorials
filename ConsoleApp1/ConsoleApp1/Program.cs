

Console.WriteLine("Welcome to the ExpensePro");

Console.WriteLine("Select the type of expense Airplane, Car, ot Uber");
string transportFair = Console.ReadLine();

Console.WriteLine("How much was for the TRANSPORTATION expense? ");
double amount = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the food expense");
double food = Convert.ToDouble(Console.ReadLine());


string path = "C:\\Users\\pasto\\Desktop\\reimburse.txt";

using (StreamWriter sw = new StreamWriter(path))
{

    sw.WriteLine($"Your {transportFair} was: {amount} ");
    sw.WriteLine($"Your food was: {food} ");
    sw.WriteLine($"Your have a total to be reimburse: {amount + food} ");
}
//string readText = File.ReadAllText(path);
//Console.WriteLine(readText);

//Console.Write("Enter text to be saved to the file: ");
//string userInput = Console.ReadLine();

//// Specify the file path
//string filePath = "C:\\Users\\pasto\\Desktop\\reimburse.txt";

//// Use StreamWriter to write to the file
//using (StreamWriter writer = new StreamWriter(filePath))
//{
//    // Write the user input to the file
//    writer.WriteLine(userInput);
//}

//Console.WriteLine($"User input has been saved to {filePath}");



