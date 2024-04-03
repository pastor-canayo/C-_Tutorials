
//string path = @"C:\Users\pasto\Desktop\CreatedFiles\testFile.txt";

//using (StreamWriter sw = new StreamWriter(path));

string[] lines = { "Perro", "Gato", "Tiger" };
File.WriteAllLines(@"C:\Users\pasto\Desktop\CreatedFiles\test2.txt", lines);

