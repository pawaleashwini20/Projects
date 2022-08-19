using System;
using System.Collections.Generic;
using System.Text;
//14.	WAP to create a Queue to add 5 objects and also remove first two and iterate over it. 
namespace Projects.Collection_test1
{
    class Queue_Demo
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(222);
            q.Enqueue(555);
            q.Enqueue(111);
            q.Enqueue(123);
            q.Enqueue(127);
            q.Enqueue(909);
            Console.WriteLine("element:");
            foreach(int i in q)
                Console.WriteLine(i);
            Console.WriteLine("Remove:");
            q.Dequeue();
            q.Dequeue();
            foreach (int i in q)
                Console.WriteLine(i);
            Console.WriteLine("Count:"+q.Count);


        }
    }
}
