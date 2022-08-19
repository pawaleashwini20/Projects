//using Projects.Practice_Pro1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_Pro1
{
    abstract class Addition
    {
        int x = 100;
        public abstract void Add();
        public abstract void sub();
    }

    class Abstraction_Demo : Addition
    {
        public override void Add()
        {
            Console.WriteLine("Addition");
        }
        public override void sub()
        {
            Console.WriteLine("Substraction");
        }

        static void Main(string[] args)
        {
            Abstraction_Demo AA = new Abstraction_Demo();
            AA.Add();
            AA.sub();

        }
    }
}
