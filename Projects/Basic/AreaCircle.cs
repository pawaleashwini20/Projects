using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Basic
{
    class AreaCircle
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter Radius:");
            double r = double.Parse(Console.ReadLine());
            double area = 3.14 * r * r;
            Console.WriteLine("Area :" + area);
        }
    }
}
