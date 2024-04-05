//Switch Statement

Console.WriteLine("Enter the age of the new candidate: ");
int age = int.Parse(Console.ReadLine());

//if (age < 18)
//{
//    Console.WriteLine("Too young to apply");
//    Console.WriteLine("Send email to candidate.");
//}
//else if (age > 65)
//{
//    Console.WriteLine("Sorry the selected age is to old");
//    Console.WriteLine("Send email to candidate");
//}
//else
//{
//    Console.WriteLine("Great you can now start the application");
//}

// Switch Statement

switch (age)
{
    case < 18:
    case > 65:
        Console.WriteLine("Sorry, your age is not within the rage we are looking for");
        break;
    case 42:
        Console.WriteLine("Great you can now start the application");
        break;
    default:
        Console.WriteLine("Great you can continue");
        break;
}

Console.WriteLine("\n============================\n");

// Application

Console.WriteLine("Choose the action you want to do:");
Console.WriteLine("1. Add emplyee");
Console.WriteLine("2. Update employee");
Console.WriteLine("3. Delete employee");

string selectedAction = Console.ReadLine();

switch (selectedAction)
{
    case "1":
        Console.WriteLine("Adding new employee ...");
        break;
    case "2":
        Console.WriteLine("Update new employee ...");
        break;
    case "3":
        Console.WriteLine("Delete new employee ...");
        break;
    default:
        Console.WriteLine("Invalid input");
        break;
}