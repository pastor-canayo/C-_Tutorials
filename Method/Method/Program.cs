//int amount = 1234;
//int months = 12;

//CalculateYearlyWage(amount, months);
//Console.ReadLine();
//static void CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked)
//{
//    Console.WriteLine($"Yearly wage: {monthlyWage * numberOfMonthsWorked}");
//}BAN


//Console.WriteLine("Enter the name of your band:");
//string name = Console.ReadLine();
//AnnounceBand(name);

//void AnnounceBand(string bandName)
//{
//    Console.WriteLine("Welcome " + bandName + " to the stage");
//}

Console.WriteLine("Enter the amount you get paid amonth:");
int amount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter how many months:");
int months = Convert.ToInt32(Console.ReadLine());
CalculateYearlyWage(amount, months);

void CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked)
{
    Console.WriteLine($"Yearly wage: {monthlyWage * numberOfMonthsWorked}");
}