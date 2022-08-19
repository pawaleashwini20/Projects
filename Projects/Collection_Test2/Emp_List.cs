using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Collection_Test2
{
    class Emp_List
    {
        static void Main(string[] args)
        {
            // List<Emp>ll = new List<Emp>();
            //ll.Add(new(Emp("a","d",1000));
            
            List<Emp> l = new List<Emp>();
            l.Add(new Emp("Deepti\t","Teacher\t", 8));
            l.Add(new Emp("Ashwini\t", "Engg\t", 10));
            l.Add(new Emp("swara\t", "Civil\t", 5));
            l.Add(new Emp("Pakhi\t", "IT\t", 3));
            foreach (Emp s in l)
            {
                Console.WriteLine(s+"\t");
            }

        }
    }
}
