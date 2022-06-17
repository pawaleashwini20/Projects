using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Loopping
{
    class Table_1_5
    {
        static void Main(string[] args)
        {
            int t = 0;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    t = i * j;
                    Console.Write(t+"\t");
                    //Console.Write(t+"\n");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
