



//string path = @"C:\Users\pasto\Desktop\CreatedFiles\my_file.txt";

//// The line below will create a text file, my_file.txt, in 
//// the Text_Files folder in D:\ drive.
//// The CreateText method that returns a StreamWriter object
//using (StreamWriter sw = File.CreateText(path));

string[] lines = { "Perro", "Gato", "Tiger" };

File.WriteAllLines(@"C:\Users\pasto\Desktop\CreatedFiles\yo.txt", lines);

Console.WriteLine("Please enter the name that you want for the text file: ");
string fileName = Console.ReadLine();

Console.WriteLine("Please type anything that you want to show in the textfile: ");
string userInput = Console.ReadLine();

File.WriteAllText(@"C:\Users\pasto\Desktop\CreatedFiles\" + fileName + ".txt", userInput);