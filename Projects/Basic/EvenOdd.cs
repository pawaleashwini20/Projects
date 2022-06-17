using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Basic
{
    class EvenOdd
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter Number:");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("Even number:" + a);

            }
            else
            {
                Console.WriteLine("Odd Number:" + a);
            }
        }
    }
}
