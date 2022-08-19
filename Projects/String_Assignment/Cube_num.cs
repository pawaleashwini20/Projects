using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.String_Assignment
{
    class Cube_num
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Square of number:" + (n * n *n));
        }
    }
}
