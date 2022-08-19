using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Collections
{
    public delegate void mydele11(int a);

    class Delegate_Demo1
    {
        public static void m1(int a)
        {
            Console.WriteLine("in m1:"+a);
        }
        public static void square(int n)
        {
            Console.WriteLine("Square is:"+n*n); 
         }
        static void Main(string[] args)
        {
           // Delegate_Demo1 d = new Delegate_Demo1();
            mydele11 mm = square;
            mm(7);
           
        }
    }
}
