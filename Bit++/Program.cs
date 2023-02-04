
using System.Security.Cryptography.X509Certificates;

int n,X=0;
String s; ;
n=int.Parse(Console.ReadLine());
for(int i=0; i < n; i++)
{
    s=Console.ReadLine();

    if (s[1] =='+')
        X++;
    else
        X--;
}
Console.WriteLine(X);