using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Loopping
{
    class EvenTable
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Table:");
            int table = 1;
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i+":"+i * i);
                }
            }
        }
    }
}
