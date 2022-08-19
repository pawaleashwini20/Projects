
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Projects.Collections
{  
    class Comparer_Demo1:IComparer<Student>
    {
        public int Compare(Student x,Student y)
        {
            return x.stu_name.CompareTo(y.stu_name);
        }


    }
    class Comparer_Demo
    {
        static void Main(string[] args)
        {
            SortedList<Student, String> ss = new SortedList<Student, string>(new Comparer_Demo1());
            ss.Add(new Student(101, "Ashwini", "CS"), "Java");
            ss.Add(new Student(102, "Sara", "ETC"), "Script");
            ss.Add(new Student(102, "Mira", "MACH"), "C++");
            ss.Add(new Student(109, "Laxmi", "ENGG"), "Pathon");
            ss.Add(new Student(106, "Zara", "IT"), "Java");
            ss.Add(new Student(108, "Natasha", "ITI"), "C++");
            ss.Add(new Student(106, "Ashu", "IIT"), "C");
            Dictionary<Student, String> dd = new Dictionary<Student, String>(ss);
            foreach (KeyValuePair<Student, String> kv in ss)
            {
                Console.WriteLine(kv.Key + "==>" + kv.Value);
            }
        }
    }
}
