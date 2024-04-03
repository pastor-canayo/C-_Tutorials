//we use the ref keyword
//to pass an argument to a method by reference.
//reference indicates to the compiler that the argument is being passed 
//as a reference instead of as a copy

int val1 = 10;
int val2 = 20;

TestFunction(val1);
Console.WriteLine(val1);

TestFunction2(ref val1);
Console.WriteLine(val1);

static void TestFunction(int arg1)
{
    arg1 += 10;
    Console.WriteLine(arg1);
}
static void TestFunction2( ref int arg1)
{
    arg1 += 10;
    Console.WriteLine(arg1);
}