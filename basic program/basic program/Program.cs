// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Enter a number: ");
int a = Console.Read();
float b = float.Parse(Console.ReadLine());
Console.WriteLine("The first value is: "+a+"\n The second value is : "+b);

double c= (a / b);
Console.WriteLine("The result is: "+c);
Console.WriteLine("Enter string array: ");

string[] number=new string[50];
number[1] = Console.ReadLine();
//string[] n = number.Split(' ');
Console.WriteLine("The string into split is: " + number[1]);