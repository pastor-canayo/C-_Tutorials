
int[] values = { 15, 7, 12, 23, 41, 28, 9, 17, 36 };

Console.WriteLine("Using break and continue");

foreach (var value in values)
{
    //Console.WriteLine($"Value is currentely {value}");

    //if(value >= 40)
    //{
    //    break;
    //}

    if(value >= 20 &&  value <= 29)
    {
        continue;
    }
    Console.WriteLine($"Value is currentely {value}");
}
