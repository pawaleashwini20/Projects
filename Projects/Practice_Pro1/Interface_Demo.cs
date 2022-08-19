using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_Pro1
{
    interface Int1
    {
        public abstract void Add();

    }
    interface Int2
    {
        public abstract void Add();
        public abstract void Sub();

    }
    class Main_Demo : Int1, Int2
    {
         void Int1.Add()
            {
                
            }
        public void Add()
        {
            Console.WriteLine("Addition...");
        }
        public void Sub()
        {
            Console.WriteLine("Substraction...");
        }
    }
    class Interface_Demo
    {
        static void Main(string[] args)
        {


            Main_Demo m = new Main_Demo();
            m.Add();
            m.Sub();

        }
    }
}
