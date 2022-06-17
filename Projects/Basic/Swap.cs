using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Basic
{
    class Swap
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter a,b value:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("a:" + a);
            Console.WriteLine("b:" + b);
            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After swap:");
            Console.WriteLine("a:" + a);
            Console.WriteLine("b:" + b);
        }
    }
}
