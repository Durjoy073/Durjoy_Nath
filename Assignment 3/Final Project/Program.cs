using Final_Project;


Console.WriteLine("Please Select data storage:");
Console.WriteLine(" 1)Database\n 2)File\n 3)Exit");
int n,m;
n =Convert.ToInt32(Console.ReadLine());

if (n == 1)
{

}
else if (n == 2)
{
    Console.WriteLine("Please Select task:");
    Console.WriteLine(" 1)Create file\n 2)Edit file\n 3)Delete file\n 4)Exit");

    m = Convert.ToInt32(Console.ReadLine());

    if (m == 1)
    {
        ForIFile createfile = new ForIFile();
        createfile.createFile();
    }
    else if (m == 2)
    {

        ForIFile editfile = new ForIFile();
        editfile.Editfile();

    }
    else if (m == 3)
    {

        ForIFile deletefile = new ForIFile();
        deletefile.Deletefile();
    }
}
else if(n == 3)
{
    return;
}