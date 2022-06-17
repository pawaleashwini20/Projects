using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Task_Que
{
    class Rect_Area
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Length And Breadth");
            double l = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Area of REactangle is:" + (l * b));
        }
    }
}
