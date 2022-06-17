using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Test_loop_1
{
    class Tress_op
    { 
            static void Main(String[] args)
            {
                int b = 0;
                do
                {
                    int a = 2;
                    b++;
                    Console.WriteLine(a++);
                }
                while (b != 3);
            }
        }

    }
