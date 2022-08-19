using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.String_Assignment
{
    class Permeter_rect
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length and breadth:");
            double l = int.Parse(Console.ReadLine());
            double b = int.Parse(Console.ReadLine());
            double p = (2*(l +b));
            Console.WriteLine("Perimeter of rectangle:"+p);
        }
    }
}
