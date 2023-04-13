// See https://aka.ms/new-console-template for more information

string[] fruits = { "apple", "banana", "mango", "goava", "strawberry", "pineapple" };


var f = fruits.GroupBy(fruit => fruit[fruit.Length - 1]) .OrderBy(group => group.Key);
var r = f.ToList();

foreach (var group in r)
{
    Console.WriteLine("Fruits with last letter"+ group.Key);
    foreach (var fruit in group)
    {
        Console.WriteLine(fruit);
    }
}