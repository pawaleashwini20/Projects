using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Methods
{
    class Arithmatic_Op
    {
        public void calculator(int a, int b,int c)
        {
            Console.WriteLine("Addition :"+(a+b+c));
        }
        public void calculator(int a, int b)
        {
            Console.WriteLine("Substraction:"+(a-b));
        }
        public void calculator(float a, float b)
        {
            Console.WriteLine("Multiplication:"+(float)(a*b));
        }
        public void calculator(double a, double b)
        {
            Console.WriteLine("Division:"+(a/b));
        }
        static void Main(string[] args)
        {
            Arithmatic_Op a = new Arithmatic_Op();
            a.calculator(2, 6);
            a.calculator(2.2f, 3.1f);
            a.calculator(10, 20, 30);
            a.calculator(4.4,2.2);
        }
    }
}
