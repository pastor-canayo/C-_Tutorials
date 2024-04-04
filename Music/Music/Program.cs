
Console.WriteLine("Enter the age of the new candidate: ");
int age = int.Parse(Console.ReadLine());

if(age < 18)
{
    Console.WriteLine("Too young to apply");
    Console.WriteLine("Send email to candidate.");
}
else if (age > 65)
{
    Console.WriteLine("Sorry the selected age is to old");
    Console.WriteLine("Send email to candidate");
}
else
{
    Console.WriteLine("Great you can now start the application");
}
DateTime today = DateTime.Now;
bool endOfMonthPaymentStarted = false;
if (today.Date.Day == 20)
{
    Console.WriteLine("Please start rnd of the month employee payments");
}
else if (today.Date.Day > 25 && endOfMonthPaymentStarted)
{
    Console.WriteLine("Payments will be late!");
}
