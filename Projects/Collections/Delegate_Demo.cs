using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Collections
{
    public delegate void mydele();
    class Delegate_Demo
    {
        public delegate int mydele2(int a,int b);
        public static int Add(int a, int b)
        {
            Console.WriteLine("Add:"+(a+b));
            return a + b;
        }
        static void greet()
        {
            Console.WriteLine("Good Morning...");
        }
        static void Main(string[] args)
        {
            mydele d1 = greet;
            d1();
            mydele2 d2 = Add;
            int r = d2(10, 20);
        }


    }
}
