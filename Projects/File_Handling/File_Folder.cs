﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Projects.File_Handling
{
   public class File_Folder
    {

        static void CreateFolder()
        {
            String path = @"D:\FileFolder";
            if (Directory.Exists(path))
            {
                Console.WriteLine("Folder is already Created...");
            }
            else
            {
                Console.WriteLine("Folder created...");
            }

        }
        static void CreateFile()
        {
            string path = @"D:\FileFolder\Test.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File Already Created...");
            }
            else
            {
                Console.WriteLine("File  created...");
            }
        }
    
   // class File_Folder
    
        static void Main(string[] args)
        {
            File_Folder.CreateFolder();
            File_Folder.CreateFile();
        }
    }
}
