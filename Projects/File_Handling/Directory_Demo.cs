using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Projects.File_Handling
{
    class Directory_Demo
    {
        static void CreateFolder()
        {
            string path = @"D:\FileFolder";
            DirectoryInfo d = new DirectoryInfo(path);
            if (d.Exists)
            {
                Console.WriteLine("Folder is already created...");
            }
            else
            {
                d.Create();
                Console.WriteLine("Folder is created...");
            }
        }
        static void CreateFile()
        {
            string path = @"D:\FileFolder\file.txt";
            FileInfo f = new FileInfo(path);
            if (f.Exists)
            {
                Console.WriteLine("File already exits...");
            }
            else
            {
                f.Create();
                Console.WriteLine("File created....");
            }

        }
        static void Main(string[] args)
        {
            Directory_Demo.CreateFolder();
            Directory_Demo.CreateFile();
        }

    }
}
