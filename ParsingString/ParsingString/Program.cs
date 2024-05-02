
//Parsing a string

Console.WriteLine("Enter the wage: ");
string wage = Console.ReadLine();

//int intWageValue = int.Parse(wage);

int wageValue;

if (int.TryParse(wage, out wageValue))
{
    Console.WriteLine("Parsing was successful: " + wageValue);
}
else
{
    Console.WriteLine("Parsing failed");
}


