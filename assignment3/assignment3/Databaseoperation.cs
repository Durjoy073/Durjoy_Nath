using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    public class Databaseoperation
    {
        public string fname { get; set; }
        public string ftext { get; set; }

        forDatabase db = new forDatabase();
        public void Createfile()
        {
            if (!Directory.Exists("UserFiles"))
            {
                Directory.CreateDirectory("UserFiles");
            }

            else
            {
                Console.WriteLine("Enter File Name With Extension:");
                fname = Console.ReadLine();

                Console.WriteLine("Creating File: " + fname);

                if (!File.Exists(fname))
                {
                    Console.WriteLine("Please enter file text:");
                    ftext = Console.ReadLine();



                    using (var writer = new StreamWriter(fname))
                    {
                        writer.Write(ftext);
                    }

                    var file = new StoreFile { FileName = fname, FileText = ftext };

                    db.storeFiles.Add(file);
                    db.SaveChanges();

                    File.WriteAllText(Path.Combine("UserFiles", fname), ftext);
                    Console.WriteLine("File has been added");
                }

                else
                {
                    Console.WriteLine("Opps! File already exists.");
                    return;
                }

            }

        }
        public void editData()
        {
            Console.Write("Enter file name: ");
            fname = Console.ReadLine();



            using (var db = new forDatabase())
            {
                var file = db.storeFiles.FirstOrDefault(f => f.FileName == fname);
                if (file == null)
                {
                    Console.WriteLine("File not found.");
                    return;
                }

                Console.Write("Update file text: ");
                ftext = Console.ReadLine();

              
                file.FileText = ftext;
                db.SaveChanges();
            }
        }

       public void deleteFile()
        {
            Console.Write("Enter File name: ");
             fname = Console.ReadLine();

            using (var db = new forDatabase())
            {
                var file = db.storeFiles.FirstOrDefault(f => f.FileName == fname);
                if (file == null)
                {
                    Console.WriteLine("File not found.");
                }
                else
                {
                    db.storeFiles.Remove(file);
                    db.SaveChanges();
                    Console.WriteLine("File has been deleted.");
                }
            }
        }

    }
}
