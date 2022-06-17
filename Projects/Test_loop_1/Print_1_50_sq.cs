using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Test_loop_1
{
    class Print_1_50_sq
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i+" ");
                }
                else 
                {
                    Console.Write(i*i+" ");
                }
            }
        }
    }
}
