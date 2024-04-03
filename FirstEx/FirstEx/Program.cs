
var timeString = DateTime.Now.ToString("HH:mm:ss");
// military time: "HH:mm:ss"
//Standar time: @"hh\:mm\:ss tt"

Console.WriteLine("The time is: " + timeString);

string firstName = "pastor";
string lastName = "Smith";
string s;
s = firstName;
var userName = "pastor";

string fullName = firstName + " " + lastName;
string employeeIdentification = String.Concat(firstName, lastName);

string empId = firstName.ToLower() + "-" + lastName.ToLower();

int length = empId.Length;

if(fullName.Contains("_ast") || fullName.Contains("Past"))
{
    Console.WriteLine("It is Pastor");
}
else
{
    Console.WriteLine("It is not Pastor");
}

userName = userName.ToLower();

Console.WriteLine(fullName);
Console.WriteLine(employeeIdentification);
Console.WriteLine(empId);
Console.WriteLine(length);
