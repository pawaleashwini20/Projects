using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Task_Que
{
    class Area_Tri
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Length and base:");
            float l = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Area of Triangle:" + (l * b) / 2);
        }
    }
}
