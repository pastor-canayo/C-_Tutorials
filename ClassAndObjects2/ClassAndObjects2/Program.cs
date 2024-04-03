
using ClassAndObjects2;

Employee employee = new Employee("Pastor Smith", "Programmer", 30, 500000);
Employee employee2 = new Employee("Pedro Garcia", "Manager", 50, 600000);

//employee.Name = "Pastor Smith";
//employee.Position = "Programmer";
//employee.Age = 30;
//employee.Salary = 500000;
//employee.Information();

//employee2.Name = "Pedro Garcia";
//employee2.Position = "Manager";
//employee2.Age = 50;
//employee2.Salary = 600000;
//employee2.Information();

Console.WriteLine($"My names is {employee.Name} and I am a {employee.Position}.  And I am" +
    $" {employee.Age} years old and I make {employee.Salary} dollars per year");

Console.WriteLine($"My names is {employee2.Name} and I am a {employee2.Position}.  And I am" +
    $" {employee2.Age} years old and I make {employee2.Salary} dollars per year");


