using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Assignment
{
    class Odd_521_229
    {
        static void Main(string[] args)
        {
            for (int i = 521; i >= 229; i--)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
