using System;
using System.Collections.Generic;
using System.Text;
//5.WAP to create SortedList where key is of Integer type and value
//string and print all key-value pairs.
  namespace Projects.Collection_Test2
{
    class Sorted_Demo
    {
        static void Main(string[] args)
        {
            SortedList<int,String> s = new SortedList<int,String>();
            s.Add(1, "A");
            s.Add(2, "B");
            s.Add(3, "C");
            s.Add(4, "P");
            s.Add(5, "E");
            Console.WriteLine("Kay===>Value");
            foreach (KeyValuePair<int,String> a in s)
            {
                Console.WriteLine(a.Key+"=> "+a.Value);
            }
          
        }
    }
}
