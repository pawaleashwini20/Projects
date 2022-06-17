using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Methods
{
    class Calulate_Area
    {
        public void area(float r)
        {
            Console.WriteLine("Area of circle:"+((3.14)*r*r));
        }
        public void area(float b, float h)
        {
            Console.WriteLine("Area of triangle:"+((b*h)/2));
        }
        public void area(int b, float h)
        {
            Console.WriteLine("Area of rectangle:"+(b*h));
        }
        public void area(int s)
        {
            Console.WriteLine("Area of Square:"+(s*s));
        }
        static void Main(string[] args)
        {
            Calulate_Area c = new Calulate_Area();
            c.area(5, 2.2f);
            c.area(5);
            c.area(2.2f, 3.3f);
            c.area(4.4f);

        }
    }
}
