using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    class Sorted_Demo
    {
        static void Main(string[] args)
        {
            SortedList<Emp,String> s = new SortedList<Emp, String>();
            s.Add(new Emp(111, "Ashwini", "Pune"), "Java");
            s.Add(new Emp(222, "Praju", "Pen"), "C++");
            s.Add(new Emp(333, "Gauri", "Khed"), "C");
            s.Add(new Emp(444, "Ram", "Mumbai"), "Python");
            s.Add(new Emp(555, "ABC", "Delhi"), "HTML");

            foreach (KeyValuePair<Emp, String> kv in s)
            {
                Console.WriteLine(kv.Key+" : "+kv.Value);
            }
        }
    }
}
