// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");
Console.WriteLine("Enter a String: ");
string s=Console.ReadLine();

StringBuilder b= new StringBuilder(s);

b.Replace('a','-');
b.Replace('e', '-');
b.Replace('i', '-');
b.Replace('o', '-');
b.Replace('u', '-');


Console.WriteLine(b.ToString());