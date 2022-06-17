using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Test_loop_1
{
    class Tress_op1
    {
        static void Main(string[] args)
        {
            int i = 1;
            int k = 1;
            while (i++ <= 5)
            {
                k *= i;
            }
            Console.WriteLine("k="+k+"i ="+i);

        }
    }
}
