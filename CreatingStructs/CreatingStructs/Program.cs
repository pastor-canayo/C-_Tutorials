
//In C#, struct is the value type data type that represents
//data structures. It can contain a parameterized constructor,
//static constructor, constants, fields, methods, properties,
//indexers, operators, events, and nested types.

//struct can be used to hold small data values that
//do not require inheritance, e.g. coordinate points,
//key-value pairs, and complex data structure.

//Structs are really used for lightweight structs, so with limited amount of data
//Behind the sscene a struct is a value type

using CreatingStructs;

Info info;
info.Description = "Pinaple Cake";
info.Hours = 2;
info.PerformedTask();