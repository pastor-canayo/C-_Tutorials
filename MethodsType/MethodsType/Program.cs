// Methods

Console.WriteLine("Enter the name of your band: ");
string name = Console.ReadLine();
AnnounceBand(name);

void AnnounceBand(string bandName)
{
    Console.WriteLine("Welcome " + bandName + " to the stage");
}

Console.WriteLine("\n==========================\n");

//wage application

Console.WriteLine("Enter the amount you get pay a month: ");
int amount = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter how many months: ");
int months = Convert.ToInt32(Console.ReadLine());
CalculateYearlyWage(amount, months);

void CalculateYearlyWage(int monthlyWage, int yearlyWage)
{
    Console.WriteLine($"Yearly Wage: {monthlyWage * yearlyWage}");
}

Console.WriteLine("\n==========================\n");

//wage application 2

Console.WriteLine("Enter the amount you get pay a month: ");
int amount2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter how many months: ");
int months2 = Convert.ToInt32(Console.ReadLine());
int totalYearlyWage = CalculateYearlyWage2(amount2, months2);

Console.WriteLine($"Yearly wage: {totalYearlyWage}");

int CalculateYearlyWage2(int monthlyWage2, int yearlyWage2)
{
    //Console.WriteLine($"Yearly Wage: {monthlyWage2 * yearlyWage2}");
    return monthlyWage2 * yearlyWage2;
}