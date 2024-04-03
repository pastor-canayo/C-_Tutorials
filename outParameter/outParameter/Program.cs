
int val1 = 10;
int val2 = 20;
int a, b;

PlusTimes(val1, val2, out a, out b);
Console.WriteLine($"{a}, {b}");
static void PlusTimes(int arg1, int arg2, out int sum, out int product)
{
    sum = arg1 + arg2;
    product = arg1 * arg2;
}
