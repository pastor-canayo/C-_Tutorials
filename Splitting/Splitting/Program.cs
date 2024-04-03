//string foods = "apple banana cherry durian eggplant fig grape honey";
string foods = "Kiwi, lemom, Kiwi, onion, potato, lemon, spinach, tomato, lemon, onion";

Console.WriteLine($"{foods}\r\n");
string[] comma = { ", " };

var foodArray = foods.Split(comma, StringSplitOptions.RemoveEmptyEntries);
foreach ( var food in foodArray)
{
    
    Console.WriteLine($"{food}\n");
}
