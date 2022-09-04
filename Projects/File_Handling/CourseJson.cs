using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace Projects.File_Handling
{
    class CourseJson
    {
        int id;
        string name;
        int fee;
        String duration;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Fee { get => fee; set => fee = value; }
        public String Duration { get => duration; set => duration = value; }
    }
    class Course_Demo
    {
        static void JsonSerializationWrite(CourseJson c)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\FileFolder\JsonFile.soap", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize<CourseJson>(fs, c);

                Console.WriteLine("Json data added");
                fs.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void JsonSerializationRead()
        {
            try
            {
                FileStream fs = new FileStream(@"D:\FileFolder\JsonFile.soap", FileMode.Open, FileAccess.Read);

                CourseJson c = JsonSerializer.Deserialize<CourseJson>(fs);
                Console.WriteLine(c.Id);
                Console.WriteLine(c.Name);
                Console.WriteLine(c.Fee);
                Console.WriteLine(c.Duration);
                fs.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void Main(string[] args)
        {
            CourseJson c= new CourseJson{ Id = 1, Name = "C#", Fee = 8900,Duration="6 Months" };
            JsonSerializationWrite(c);
            JsonSerializationRead();
            Console.ReadLine();
        }

    }
}
