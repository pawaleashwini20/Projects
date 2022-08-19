using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Projects.Collections
{
    class List_op
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>();
            li.Add(100);
            li.Add(200);
            li.Add(300);
            li.Add(400);                      
            li.Add(500);
            Console.WriteLine("Total Count is:"+li.Count);
            Console.WriteLine("Using for Loop:\n");
            li[1] = 1000;
            li.Insert(5, 20000);//(position,value)
            for (int i = 0; i < li.Count; i++)
            {
                Console.WriteLine(li[i]);
            }
            Console.WriteLine("Using foreach loop:\n");
            foreach (int a in li)
            {
                Console.WriteLine(a);
            }
            List<int> lst = new List<int>() {11,22,33,44 };
            lst.AddRange(li);//after lst element add li element
            lst.InsertRange(2,li);
            Console.WriteLine("After using AddRange...");
            for (int i = 0; i < lst.Count; i++)
            {
                Console.WriteLine(lst[i]);
            }
        }
    }
}
