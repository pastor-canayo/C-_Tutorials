//Collections - Array, List and Dictionary
//In old days zero based indexing made memory managment easier
// Also made collections worked a lot quicker when computers were slow



string[] daysOfWeek =
{
    "Monday",
    "Tuesday",
    "Tiger",
    "Thursday",
    "Friday",
    "Saturday",
    "Sunday"
};
Console.WriteLine("Before: ");
foreach (string day in daysOfWeek)
{
    Console.WriteLine(day);
}

daysOfWeek[2] = "Wednesday";
Console.WriteLine("\n\nAfter: ");
foreach (string day in daysOfWeek)
{
    Console.WriteLine(day);
}


