using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Collection_Practice
{
    public class Student:IComparable<Student>
    {
        public int id { get; set; }
        public String name { get; set; }
        public int CompareTo(Student other)
        {
            //greater 1  & Less  -1  & equal  0
            if (other.id > this.id)
            {
                return 1;

            }
            else if(other.id==this.id)
            {
                return 0;
            }
            else 
            { 
                return -1;
            }

        }
    }
    class Comparable_Demo
    {
        static void Main(string[] args)
        {
            List<int> l = new List<int>();
            l.Add(11);
            l.Add(34);
            l.Add(22);
            l.Add(30);
            l.Add(78);
            l.Sort();
            for (int i = 0; i < l.Count; i++)
            {
                Console.WriteLine(l[i]);
            }
            Student stud1 = new Student { id = 101, name = "ABC" };
            Student stud2 = new Student { id = 105, name = "PQR" };
            Student stud3 = new Student { id = 104, name = "SBC" };
            Student stud4 = new Student { id = 103, name = "ASD" };
            Student stud5 = new Student { id = 102, name = "SWE" };
            List<Student> stud = new List<Student> { stud1, stud2, stud3, stud4, stud5 };
            stud.Sort();
            foreach (var item in stud)
            {
                Console.WriteLine(item.id + ":" + item.name);
            }
        }

    }
}
