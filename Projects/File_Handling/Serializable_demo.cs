using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
namespace Projects.File_Handling
{
    [Serializable]
    public class Student
    {
        public int rno { get; set; }
        public String name { get; set; }
        public int percentage { get; set; }
    }
    class Serializable_demo
    {
        /*static void CreateFolder()
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
            string path = @"D:\FileFolder\BinaryFile.dat";
            if (File.Exists(path))
            {
                Console.WriteLine("File Already Created...");
            }
            else
            {
                Console.WriteLine("File  created...");
            }
        }*/


        static void BinarySerilizationWrite(Student stud)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\FileFolder\BinaryFile.dat", FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, stud);
                Console.WriteLine("Binary data Added....");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void BinarySerilizationRead()
        {
            try
            {
                FileStream fs = new FileStream(@"D:\FileFolder\BinaryFile.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                Student stud = (Student)bf.Deserialize(fs);
                Console.WriteLine(stud.rno);
                Console.WriteLine(stud.name);
                Console.WriteLine(stud.percentage);
                fs.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void XmlSerilizationWrite(Student stud)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\FileFolder\xmlFile1.xml", FileMode.Create, FileAccess.Write);
                XmlSerializer xs = new XmlSerializer(typeof(Student));
                xs.Serialize(fs, stud);
                Console.WriteLine("Binary data Added....");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void XmlSerilizationRead()
        {
            try
            {
                FileStream fs = new FileStream(@"D:\FileFolder\xmlFile1.xml", FileMode.Open, FileAccess.Read);
                XmlSerializer xs = new XmlSerializer(typeof(Student));
                Student stud = (Student)xs.Deserialize(fs);
                Console.WriteLine(stud.rno);
                Console.WriteLine(stud.name);
                Console.WriteLine(stud.percentage);
                fs.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void Main(string[] args)
        {
            Student stud = new Student { rno = 101, name = "Ashwini", percentage = 89 };
           // CreateFolder();
           // CreateFile();
           
           // BinarySerilizationWrite(stud);
            //BinarySerilizationRead();

            XmlSerilizationWrite(stud);
              XmlSerilizationRead();
        }
    }
}
