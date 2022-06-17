using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Conditional_Stmt
{
    class Ter_GreatNum
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter Two number:");
            int a = int.Parse(Console.ReadLine());
            int b=int.Parse(Console.ReadLine());
            int r=a>b?a: b;
            Console.WriteLine("Greater number is:" + r);
        }
    }
}
