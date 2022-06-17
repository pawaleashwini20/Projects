using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Task_Que
{
    class Cube_Num1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Cube of number:" + (n * n*n));
        }
    }
}
