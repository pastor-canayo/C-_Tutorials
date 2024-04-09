
Console.WriteLine("Enter the age of the new candidate: ");
int age = int.Parse(Console.ReadLine());

//if(age < 18)
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
switch (age)
{
    case < 18:
    case > 65:
        //Console.WriteLine("Too young to apply fro the job");
        Console.WriteLine("Sorry, your AGE IS NOT WITHIN THE RANGE WE ARE LOOKING FOR");
        break;
    //case > 65:
    //    Console.WriteLine("Sorry, the selected age is too old");
    //    break;
    case 42:
        Console.WriteLine("Great, you can start now with the application");
        break;
    default:
        Console.WriteLine("great you can continue");
        break;
}

Console.WriteLine("\n======================\n");
//CREATING AN APPLICATION

Console.WriteLine("Choose the action you want to do:");
Console.WriteLine("1. Add employee");
Console.WriteLine("2. Update employee");
Console.WriteLine("3. Delete employee");
Console.WriteLine("99. Exit application");
string selectedAction = Console.ReadLine();
while (selectedAction != "99")
{
    switch (selectedAction)
    {
        case "1":
            Console.WriteLine("Adding new employee ...");
            break;
        case "2":
            Console.WriteLine("Updating new employee ...");
            break;
        case "3":
            Console.WriteLine("Deleting new employee ...");
            break;
        default:
            Console.WriteLine("Invalid input");
            break;
    }
    Console.WriteLine("Choose the action you want to do:");
    Console.WriteLine("1. Add employee");
    Console.WriteLine("2. Update employee");
    Console.WriteLine("3. Delete employee");
    Console.WriteLine("99. Exit application");
    selectedAction = Console.ReadLine();
}
Console.WriteLine("Closing application");
