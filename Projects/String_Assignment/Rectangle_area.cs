using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.String_Assignment
{
    class Rectangle_area
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length & breadth:");
            double l = int.Parse(Console.ReadLine());
            double b= int.Parse(Console.ReadLine());
            Console.WriteLine("Area:"+l*b);
        }
    }
}
