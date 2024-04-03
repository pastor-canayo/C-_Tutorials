
//string signal = "";
//while (signal != "x")
//{
//    if (signal == "x")
//    {
//        Console.WriteLine("Abort application");
//    }
//    Console.WriteLine("Enter a nummber to be added: ");
//    int num1 = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine("Enter a second number to be added: ");
//    int num2 = Convert.ToInt32(Console.ReadLine());

//    int result = num1 + num2;

//    Console.WriteLine("The addition of the two numbers is: " + result);
//}
Console.WriteLine("Enter x to coninue: ");
string letter = Console.ReadLine();
  while (letter == "x" )
{
    const string chars = "abcdefghijklmnopqrstuvwxyz";
    var random = new Random();
    int lenght = random.Next(1, 10);
    int lenght2 = random.Next(1, 10);
    string random2 = "";
    string random3 = "";
    for (int i = 0; i < lenght; i++)
    {
        int a = random.Next(chars.Length);
        random2 += chars.ElementAt(a);
    }
    for (int i = 0; i < lenght2; i++)
    {
        int b = random.Next(chars.Length);
        random3 += chars.ElementAt(b);
    }

    Console.WriteLine("Your first name is: " + random2);
    Console.WriteLine("Your last name is: " + random3);
}
   

    
  
    
   

