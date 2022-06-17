using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Basic
{
    class SwapWithoutThirdV
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter Value of a,b");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("a:" + a);
            Console.WriteLine("b:" + b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("After Swapping:");
            Console.WriteLine("a:" + a);
            Console.WriteLine("b:" + b);
        }
    }
}
