
using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Collections
{
    public delegate int del(int a, int b);
    class Delegate3

    {
        public static int Add(int a, int b)
        {
           Console.WriteLine("Add:"+(a+b));
            return a + b;
        }
        public static int Mult(int a, int b)
        {
            Console.WriteLine("Mult:" + (a * b));
            return a * b;
        }
        static void Main(string[] args)
        {
            Delegate3 d = new Delegate3();
            Console.WriteLine("multicast...");
            del aa = Add;
            aa = aa + Mult;
            aa(10, 20);
           
            // Console.WriteLine("multicast:" + aa);
            // d1(2, 6);

            // del d2 = Mult;
            //d2(3, 9);
            //d/2 = d2 + d1;
            // Console.WriteLine("multicast:"+d2);
        }
    }
}
