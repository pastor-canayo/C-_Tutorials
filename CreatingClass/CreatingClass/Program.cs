using CreatingClass;

Console.WriteLine("Creating an employee");
Console.WriteLine("=======================\n");
//we are going to instantiate a emplyee
Employee pastor = new Employee("Pastor", "Canayo", "pastor@hotmail.com",
    new DateTime(1979, 1, 16), 25);

pastor.DisplayEmployeeDetails();
pastor.PerformWork();
pastor.PerformWork();
pastor.PerformWork(5);
pastor.PerformWork();

double recievedWagePastor = pastor.RecieveWage(true);
Console.WriteLine($"Wage paid (message from Program): {recievedWagePastor}");