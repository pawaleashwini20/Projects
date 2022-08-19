using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.String_Assignment
{
    class Square_number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter base & height:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Square of number:"+(n*n));
        }
    }
}
