using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Collection_test1
{
    class Stack_Demo
    {
        static void Main(string[] args)
        {
            Stack<String> s = new Stack<string>();
            s.Push("Ashwini");
            s.Push("Pawale");
            s.Push("Ram");
            s.Push("ABCD");
            s.Push("Radha");
            s.Push("PQR");
            foreach (String ss in s)
            {
                Console.WriteLine(ss);
            }
            Console.WriteLine("After operation:");
            s.Pop();
            Console.WriteLine("Topmost element:"+s.Peek());
            foreach (String ss in s)
            {
                Console.WriteLine(ss);
            }
        }
    }
}
