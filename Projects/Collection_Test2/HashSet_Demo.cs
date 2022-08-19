using System;
using System.Collections.Generic;
using System.Text;
// 4.	WAP to add user defined objects of type Employee in a HashSet employee object. 
// Make sure if I create 2 different objects with same data the other
// one should not be added as hashset stores unique objects.
//
namespace Projects.Collection_Test2
{
    class HashSet_Demo
    {
        static void Main(string[] args)
        {
            HashSet<Emp> h = new HashSet<Emp>();
            h.Add(new Emp("Ashu\t", "IT\t", 111));
            h.Add(new Emp("Pooja\t", "CS\t", 222));
            h.Add(new Emp("Ashwini\t", "III\t",333));
            h.Add(new Emp("Swara\t", "Mech\t", 444));
            h.Add(new Emp("Pooja\t", "CS\t", 222));
            h.Add(new Emp("Swara\t", "Mech\t", 444));
            foreach (Emp s in h)
            {
                Console.WriteLine(s);
            }

        }
    }
}
