using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Collections
{
    class Queue_Demo
    {
        static void Main(string[] args)
        {
            Queue<int>q=new Queue<int>();
            q.Enqueue(101);
            q.Enqueue(102);
            q.Enqueue(103);
            q.Enqueue(104);
            q.Enqueue(105);
            Console.WriteLine("Count is"+q.Count);
            foreach(int s in q)
            {
                Console.WriteLine(s);     
            }
            q.Dequeue();
            q.Dequeue();
            Console.WriteLine("Dequeue...");
            foreach (int s in q)
            {
                Console.WriteLine(s);
            }
            q.Peek();
            Console.WriteLine("peek operation...");
            foreach (int s in q)
            {
                Console.WriteLine(s);
            }
        }
    }
}
