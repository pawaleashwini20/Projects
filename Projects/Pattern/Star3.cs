using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Pattern
{
    class Star3
    {
        static void Main(string[] args)
        {
            int n = 5;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 || i == (n-1) || j == 0 || j == (n-1))
                    {
                        Console.Write("*");
                    }
                    else 
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
