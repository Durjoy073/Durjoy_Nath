String a, b;
a=Console.ReadLine();
a = a.ToLower();
b=Console.ReadLine();
b = b.ToLower();

if (a.CompareTo(b) < 0)
    Console.WriteLine("-1");
else if (a.CompareTo(b) > 0)
    Console.WriteLine("1");
else
    Console.WriteLine("0");