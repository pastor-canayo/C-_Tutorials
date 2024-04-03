 
Console.WriteLine("Please enter the name of the text file: ");
string fileName = Console.ReadLine();

Console.WriteLine("Please type anything that you want to show in the text file: ");
string userInput = Console.ReadLine();

File.WriteAllText(@"C:\Users\pasto\Desktop\CreatedFiles\" + fileName + ".txt", userInput);


   