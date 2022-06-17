using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Array_1D_Test
{
    class Outputcs
    {
            static int mcCartyCounter = 100;
            public static int mcCarthy(int n)
            {
                mcCartyCounter++;
                if (n > 100)
                    return n - 10;
                else
                    return mcCarthy(n + 11);
            }
            public static void Main(String[] arg)
            {
                Console.WriteLine(mcCarthy(100) + "  " + mcCartyCounter);
            }
        }

    }

