using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Basic
{
    class Power
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter base,Exponential:");
            int b = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int result = 1;
            while (e > 0)
            {
                result = result*b;
                e--;
            }
            Console.WriteLine("power is:"+result);
        }
    }
}
