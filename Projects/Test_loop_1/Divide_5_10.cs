using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Test_loop_1
{
    class Divide_5_10
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 5 != 0 || i % 10 != 0)
                {
                    Console.Write(i+" ");
                }
            }
        }
    }
}
