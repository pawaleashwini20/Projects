using System;
using System.Collections.Generic;
using System.Text;
//8.	WAP to create SortedList<Employee,string> where key is
//of Employee type and value is departmentname(string) he works in. SortedList should
//maintain data in descending order 
//of salary.

namespace Projects.Collection_Test2
{
    class Sort_Emp
    {
        static void Main(string[] args)
        {
            SortedList<Emp,String> l = new SortedList<Emp,String>();
            l.Add(new Emp("Deepti\t", "Teacher\t", 8),"A");
            l.Add(new Emp("Ashwini\t", "Engg\t", 10),"B");
            l.Add(new Emp("swara\t", "Civil\t", 5),"Z");
            l.Add(new Emp("Pakhi\t", "IT\t",3),"P");
            foreach(KeyValuePair<Emp,String>s in l)
            {
                Console.WriteLine(s); 
            }

        }

    }
}
