using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Collection_Practice
{
    class Link_list
    {
        static void Main(string[] args)
        {
            LinkedList<String> ll = new LinkedList<String>();
            ll.AddFirst("Red");
            ll.AddLast("Yellow");
            ll.AddFirst("Pink");
            ll.AddLast("Orange");
            foreach (String s in ll)
            {
                Console.WriteLine(s);
            }
            LinkedListNode<string> nn =ll.Find("Pink");
            ll.AddBefore(nn, "Red");
            ll.AddAfter(nn,"green");
            foreach (String s in ll)
            {
                Console.WriteLine(s);
            }
        }
    }
}
