using Final_Project;

if (!Directory.Exists("UserFiles"))
{
Directory.CreateDirectory("UserFiles");
}


Console.WriteLine("Please Select data storage:");
Console.WriteLine("1)Database\n2)File\n3)Exit");
int n,m;
n =Convert.ToInt32(Console.ReadLine());

if (n == 1)
{
    Console.WriteLine("Please Select task:");
    Console.WriteLine("1)Create file\n2)Edit file\n3)Delete file\n4)Exit");
  
    m = Convert.ToInt32(Console.ReadLine());

    if (m == 1)
    {
        ForIFile dcreatefile = new ForIFile();
        dcreatefile.createFile();
    }
    else if (m == 2) { }
    else if (m == 3) { }
   
        
}
else if (n == 2)
{
    Console.WriteLine("Please Select task:");
    Console.WriteLine("1)Create file\n2)Edit file\n3)Delete file\n4)Exit");

    m = Convert.ToInt32(Console.ReadLine());

    if (m == 1)
    {

    }
    else if (m == 2) { }
    else if (m == 3) { }
}
else if (n == 3)
{
    return;
}