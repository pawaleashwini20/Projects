using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.String_Assignment
{
    class triangle_Area
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter base & height:");
            double h = int.Parse(Console.ReadLine());
            double b = int.Parse(Console.ReadLine());
            Console.WriteLine("Area:" + (h * b)/2);
        }
    }
}
