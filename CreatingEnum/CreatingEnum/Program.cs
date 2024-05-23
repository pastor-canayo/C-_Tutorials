
using CreatingEnum;

Student pastor = new Student("Pastor", "Canayo", 20,"pastor@gmail.com", CarType.Lamborghini);


Student pedro = new Student("Pedro", "Smith", 40, "pedro@gmail.com", CarType.Tesla);
Student alex = new Student("Alex", "Ramirez", 19, "pedro@gmail.com", CarType.Toyota);
Student juana = new Student("Juana", "Garcia", 35, "juana@gmail.com", CarType.Ferrari);
Student john = new Student("John", "Salazar", 40, "john@gmail.com", CarType.Tesla);
Student monty = new Student("MOnty", "Eggett", 55, "monty@gmail.com", CarType.Tesla);
Student piero = new Student("Piero", "Huallaga", 40, "piero@gmail.com", CarType.Tesla);


Student[] students = new Student[7];
students[0] = pastor;
students[1] = pedro;
students[2] = alex;
students[3] = juana;
students[4] = john;
students[5] = monty;
students[6] = piero;

foreach (Student e in students)
{
    e.DisplayInformation();
    var numberOfHoursWorked = new Random().Next(15);
    e.PerformWork(numberOfHoursWorked);
    e.TypeOfCar();
}