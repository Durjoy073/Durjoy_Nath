// See https://aka.ms/new-console-template for more information
int i,n,s = 0;
Console.WriteLine("Enter The number element: ");
n=int.Parse(Console.ReadLine());
int[] arr = new int[n];
Console.WriteLine("Enter The Element of  array: ");
for ( i = 0; i <arr.Length; i++)
{
    arr[i]=int.Parse(Console.ReadLine());
}

for ( i = 0; i <arr.Length; i++)
{
    s+= arr[i];
}
Console.WriteLine("The sum of array is: "+s);