using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Collections
{
    class Sorted_Demo
    {
        static void Main(string[] args)
        {
            SortedList<Employee, String> s = new SortedList<Employee,string>();
            s.Add(new Employee(111, "Kamal", "CS"),"java");
            s.Add(new Employee(112, "Ashwini", "IT"), "C++");
            s.Add(new Employee(113, "Gauri", "Sci"), "Python");
            s.Add(new Employee(114, "Zahir", "Engi"), "java");
            s.Add(new Employee(115, "Asha", "CS"), "C");
            foreach(KeyValuePair<Employee,String>kv in s)
           {
                Console.WriteLine(kv.Key+"\t==>"+kv.Value);  
            }
            SortedList<Employee, String> ss = new SortedList<Employee, String>();
            ss.Add(new Employee(1, "ASDF", "Mach"),"JS");
        }
    }
}
