
int[] values = { 15, 7, 12, 23, 41, 28, 9, 17, 36 };

Console.WriteLine("Using break and continue");

foreach(int value in values)
{
    Console.WriteLine($"Vallue is currentely : {value}" );
    if (value >= 40)
    {
        break;
    }
}
