﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Pattern
{
    class Num2
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i+" ");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
