using System;
using System.Collections.Generic;
using System.Text;
//3.WAP to create a Queue with some colors (String) using generics.
namespace Projects.Collection_Test2
{
    class Color1
    {
        static void Main(string[] args)
        {
            Queue<String> q = new Queue<string>();
            q.Enqueue("Pink");
            q.Enqueue("Yellow");
            q.Enqueue("Green");
            q.Enqueue("Red");
            q.Enqueue("Blue");
            foreach (string s in q)
            {
                Console.WriteLine(s);
            }
        }
    }
}
