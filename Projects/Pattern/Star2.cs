using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Pattern
{
    class Star2
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
