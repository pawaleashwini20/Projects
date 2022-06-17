using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Basic
{
    class AreaTri
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter Height and Base");
            double h = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double area = (h * b) / 2;
            Console.WriteLine("Area:" + area);
        }
    }
}
