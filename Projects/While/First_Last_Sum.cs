using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.While
{
    class First_Last_Sum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int num = int.Parse(Console.ReadLine());
            int num2,rev=0,sum=0,fd=0,ld=0,S=0;
            ld = num % 10;
            while (num > 0)
            {
                rev = num % 10;
                sum = (sum* 10) + rev;
                num = num / 10;
                
            }
            fd = sum % 10;
            S = fd + ld;
            Console.WriteLine("rev" + fd);
            Console.WriteLine("last" + ld);
            Console.WriteLine("First last sum:" + S);
        }
    }
}
