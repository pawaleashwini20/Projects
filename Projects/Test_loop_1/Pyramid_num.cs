using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Test_loop_1
{
    class Pyramid_num
    {
        static void Main(string[] args)
        {
            int size = 5;
            for (int i = 0; i < size; i++)
            {
                // print spaces
                for (int j = 0; j < size - i - 1; j++)
                {
                    Console.Write(" ");
                }
                // print stars
                for (int k = 0; k < 2 * i + 1; k++)
                {
                    Console.Write(i+1);
                }
                Console.WriteLine();
            }
         }

      }
 }

