using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Collections
{
    class Linked_List
    {
        static void Main(string[] args)
        {
            LinkedList<int> L=new LinkedList<int>();
            L.AddFirst(101);
            L.AddFirst(103);
            L.AddLast(104);
            L.AddLast(105);
            L.AddLast(102);
            foreach (int a in L)
            {
                Console.WriteLine(a);
            }
            L.Remove(105);
            Console.WriteLine("After removing ...");
            foreach(int a in L)
            {
                Console.WriteLine(a);
            }
            L.AddLast(109);
            L.AddLast(108);
           // int x = L.First();
            Console.WriteLine("after new element Adding...");
           foreach (int a in L)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("//////////AddFirst/AddLast/////////");
            LinkedListNode<int> nn = L.Find(101);
            L.AddBefore(nn, 10000);
            L.AddAfter(nn, 20000);
            Console.WriteLine("Size:"+L.Count);
            foreach (int a in L)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("////Last-First");
            // int x = L.First;
            //Console.WriteLine(L.Last());
            //int last = L.Last();
            Console.WriteLine("Contains:"+L.Contains(109));
            Console.WriteLine("remove:");
            L.Remove(101);
            foreach (int a in L)
            {
                Console.WriteLine(a);
            }
        }
    }
}
