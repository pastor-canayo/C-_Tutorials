//Working with strings

var timeString = DateTime.Now.ToString(@"hh\:mm\:ss tt");
//Military time: "HH:mm:ss"
//Standar time: @"hh\:mm\:ss tt"
Console.WriteLine("This is the time: " + timeString);

string firstName = "_astor";
string lastName = "Smith";
string s;
s = firstName;
string fullName = firstName + " " +  lastName;
string fullNameConcat = String.Concat(firstName, lastName);
string fullNameLower = firstName.ToLower() + "-" + lastName.ToLower();
int fullNameLenght = fullName.Length;

if(fullName.Contains("past") || fullName.Contains("Past"))
{
    Console.WriteLine("It is Pastor");
}
else
{
    Console.WriteLine("It is not not not not Pastor");
}

Console.WriteLine(firstName);
Console.WriteLine(fullName);
Console.WriteLine(fullNameConcat);
Console.WriteLine(fullNameLower);
Console.WriteLine(fullNameLenght);



