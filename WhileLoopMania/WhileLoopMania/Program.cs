Console.WriteLine("What word do you want the program to print?");
var word = Console.ReadLine();

Console.WriteLine("How many times do you want that word to be printed?");
int printed = Convert.ToInt32(Console.ReadLine());

int i = 0;
while (i <= printed)
{
    Console.WriteLine($"{i} = {word}");
    i++;
    if (i == 26)
    {
        Console.WriteLine("This is the day of my birthday");
        i++;
    }
}
