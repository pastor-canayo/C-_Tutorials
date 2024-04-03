//try - block of code to try
//catch -(Exception e) - block of code to handle the errors
try
{
    int[] numbers = { 1, 2, 3 };
    Console.WriteLine(numbers[10]);
}
catch(Exception e)
{
    Console.WriteLine("Something went wrong with the program");
}
finally
{
    Console.WriteLine("The 'try catch' is finished");
}
