
// If Statements 
//An if statement is a programming construct that allows
//you to make decisions based on certain conditions. It helps
//you control the flow of your program by executing different
//blocks of code depending on whether a given condition is true or false.

Console.WriteLine("Enter the age of the new candidate for the job: ");
int age  = int.Parse(Console.ReadLine());

if (age < 18)
{
    Console.WriteLine("too young to apply for the job");
    Console.WriteLine("Send email to candidate");
}
    
else if (age > 25)
{
    Console.WriteLine("Sorry the selected age is too old for the job");
    Console.WriteLine("Send email to candidate");
}

else
{
    Console.WriteLine("Grreat you cna now start the application");
}
    