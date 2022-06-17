using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Pattern
{
    class Star1
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 5; i++)
            {
                for (int j = 0; j <= 5; j++)
                {
                    Console.Write("*");                
                }
                Console.WriteLine(" ");
            }
        }
    }
}
