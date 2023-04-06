using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class ForIFile
    {

        public string fname { get; set; }


        public void createFile()
        {
            if (!Directory.Exists("UserFiles"))
            {
                Directory.CreateDirectory("UserFiles");
            }

            Console.WriteLine("Enter File Name With Extension:");
            fname = Console.ReadLine();
           
            Console.WriteLine("Creating File: " + fname);

            if (!File.Exists(fname))
            {
                Console.WriteLine("Please enter file text:");
                var ftext = Console.ReadLine();

              

                using (var writer = new StreamWriter(fname))
                {
                    writer.Write(ftext);
                }

                File.WriteAllText(Path.Combine("UserFiles", fname), ftext);

                Console.WriteLine("File has been created");
            }
        
            else 
            { 
                Console.WriteLine("Opps! File already exists.");
                return;
            }

          
           
        }


        public void Editfile()
        {
            Console.Write("Enter file name: ");
             fname = Console.ReadLine();

            if (fname == null)
            {
                Console.WriteLine("File not found.");
                return;
            }

            else
            {
                Console.Write("Enter new file text: ");
                string ftext = Console.ReadLine();

                File.WriteAllText(Path.Combine("UserFiles", fname), ftext);

                Console.WriteLine("File updated successfully.");
            }
        }

        public void Deletefile()
        {
            Console.Write("Enter file name: ");
            fname = Console.ReadLine();

                string path = Path.Combine("UserFiles", fname);
                if (File.Exists(path))
                {
                    File.Delete(path);
                    Console.WriteLine("File has deleted successfully.");
                }
                else
                {
                    Console.WriteLine("File not found.");
                }
            }




        }
}

    


    

