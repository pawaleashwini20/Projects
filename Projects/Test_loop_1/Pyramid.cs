using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Test_loop_1
{
    class Pyramid
    {
        static void Main(string[] args)
        {
            int size = 5;
            for (int i = 0; i < size; i++)
            {
                // print spaces
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                // print number
                for (int k = 0; k < 2 * (size - i) - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }    }
    }
}
