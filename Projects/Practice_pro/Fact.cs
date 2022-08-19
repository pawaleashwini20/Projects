using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    class Fact
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int n = int.Parse(Console.ReadLine());
            int fact = 1;
            for (int i = 1; i <=n; i++)
            {
                fact = fact * i;

            }
            Console.WriteLine(fact);
        }
    }
}
