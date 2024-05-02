// Employee Application

using CreatingClassesAndObjects;

Console.WriteLine("Creating an employee");
Console.WriteLine("==========================\n");

Employee pastor = new Employee("Pastor", "Canayo", "pastor@gmail.com", 
    new DateTime(1980, 1, 16), 25, EmployeeType.Manager);

Employee pedro = new Employee("Pedro", "Smith", "pedro@gmail.com",
    new DateTime(1990, 5, 19), 25, EmployeeType.Researcher);
pastor.DisplayEmployeeDetails();

pastor.PerformWork();
pastor.PerformWork();
pastor.PerformWork(5);
pastor.PerformWork();

double recievedWagePastor = pastor.RecieveWage(true);
Console.WriteLine($"Wage paid (message from program: {recievedWagePastor})");

pedro.DisplayEmployeeDetails();
pedro.PerformWork();
pedro.PerformWork();
pedro.PerformWork(5);
pedro.PerformWork();
double recievedWagePedro = pedro.RecieveWage(true);
Console.WriteLine($"Wage paid (message from program: {recievedWagePedro})");