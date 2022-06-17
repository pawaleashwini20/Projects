using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Loop_test_2
{
    class RedBlue
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                String r = (i % 3 == 0) ? "red" : (i % 5 == 0) ? "blue" : "RedBlue";
                Console.WriteLine(i+":"+r+"  ");
            }
        }
    }
}
