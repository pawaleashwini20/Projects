using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Projects.Collection_Practice
{
  public class Student11
    {
        public int id{ get; set; }
        public String name { get; set; }

    }
   public class Student11Comparar:IComparer<Student11>
    {

        public int Compare(Student11 x, Student11 y)
        {
            //throw new NotImplementedException();
            if (x.id > y.id)
            {
                return 1;
            }
            else if (x.id == y.id)
            {
                return 0;
            }
            else 
            {
                return -1;
            }

        }

       /* public int Compare([AllowNull] Student11 x, [AllowNull] Student11 y)
        {
            throw new NotImplementedException();
        }*/
    }
    class Comparer_Demo
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

            Student11 stud1 = new Student11 { id = 101, name = "ABC" };
            Student11 stud2 = new Student11 { id = 105, name = "PQR" };
            Student11 stud3 = new Student11 { id = 104, name = "SBC" };
            Student11 stud4 = new Student11 { id = 103, name = "ASD" };
            Student11 stud5 = new Student11 { id = 102, name = "SWE" };
            List<Student11> stud = new List<Student11> {stud1,stud2, stud3, stud4, stud5 };
            Student11Comparar comparer=new Student11Comparar();
            stud.Sort((IComparer<Student11>)comparer);
            foreach (var item in stud)
            {
                Console.WriteLine(item.id + ":" + item.name);
            }
        }
    }
}
