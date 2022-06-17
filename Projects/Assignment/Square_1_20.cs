using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Assignment
{
    class Square_1_20
    {
        static void Main(string[] args)
        {
            int sq = 1;
            for (int i = 1; i <= 20; i++)
            {
                sq = i * i;
                Console.WriteLine(i+" * "+i+":"+sq);
            }
        }
    }
}
