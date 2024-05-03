// Arrays are a built-in structure in the language which allow us to store multiple 
//multiple variables
//One single array will be able to store a number of variables
//when working with arrays these variables need to be the same type
//Items in the array can be accessed using an index

int[] sampleArray1 = new int[5];
//passing the initial values
int[] sampleArray2 = new int[] {1,2,3,4,5};

Console.WriteLine("How many students IDs do you want to register?");
int lenght = int.Parse(Console.ReadLine());

int[] studentIds = new int[lenght];

var testId = studentIds[0];

for (int i = 0; i < lenght; i++)
{
    Console.WriteLine("Enter the student ID: ");
    int id = int.Parse(Console.ReadLine());
    studentIds[i] = id;
}
for (int i = 0; i < studentIds.Length; i++)
{
    Console.WriteLine($"ID{i + 1}: \t{studentIds[i]}");
}