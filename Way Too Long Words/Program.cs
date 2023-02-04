int n=int.Parse(Console.ReadLine());
int i;
string s;
for (i=0;i<n;i++)
{
    s=Console.ReadLine();

    int w = s.Length;

    if (w>10)
    {
        Console.WriteLine(s[0]+""+(w - 2) +""+(s[w-1]));
    }
    else
        Console.WriteLine(s);
}
