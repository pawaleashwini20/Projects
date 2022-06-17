using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Loopping
{
    class Square_odd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else 
                {
                    Console.WriteLine(i*i);
                }
            }
        }
    }
}
