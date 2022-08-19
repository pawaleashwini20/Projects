using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    /*
     1
     22
     333
     4444
     */
    class Pattern
    {
        static void Main(string[] args)
        {
            int n = 1;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(n);
                }
                Console.WriteLine();
                n++;
            }
        }
    }
}
