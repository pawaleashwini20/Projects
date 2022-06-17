using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Pattern
{
    class Num5
    {
        static void Main(string[] args)
        {
            int k = 1;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(k +" ");
                    k++;
                }
                Console.WriteLine();
            }
        }
    }
}
