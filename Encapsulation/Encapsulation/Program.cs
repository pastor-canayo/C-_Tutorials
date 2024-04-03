//Encapsulation
//Encapsulation is defined as the wrapping up of data
//and information under a single unit. It is the mechanism
//that binds together the data and the functions that manipulate
//them. In a different way, encapsulation is a protective shield
//that prevents the data from being accessed by the code outside
//this shield.

using Encapsulation;

Employees employees = new Employees();
employees.EmployeeName = "Mike";
employees.EmployeeAge = 30;


Console.WriteLine("Employee Name: " + employees.EmployeeName);
Console.WriteLine("Employee Age: " + employees.EmployeeAge);
