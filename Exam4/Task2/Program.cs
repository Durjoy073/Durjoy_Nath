// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;

List<(int id, string name, int age)> persons = new List<(int id, string name, int age)>();
persons.Add((1, "Jalaluddin", 42));
persons.Add((2, "Hasan", 32));
persons.Add((3, "Maruf", 23));
persons.Add((4, "Hasan", 33));


var sort= persons.OrderBy(person=> person.name).ThenBy(person=>person.age);

var s = sort.ToList();

foreach (var person in s)
{
    Console.WriteLine(" " + person.name + "," + "" + person.age);
}
