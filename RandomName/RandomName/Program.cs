
const string chars = "abcdefghijklmnopqrstuvwxyz";
var random = new Random(); 
int lenght = random.Next(1, 10);
int lenght2 = random.Next(1, 10);
string random2 = "";
string random3 = "";

for(int i = 0; i < lenght; i++)
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