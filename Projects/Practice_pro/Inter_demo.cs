using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    interface A
    {
        public static int b = 10;
        public void Add();
        public void sub();
    }
    interface B
    {
        public void Add();
        public void sub();
    }
    class unit:A,B
    {
        public void Add()
        {
            Console.WriteLine("Interface 1 Addition...");
        }
        void B.Add()
        {
            Console.WriteLine("Interface 2 Addition...");
        }
        public void sub()
        {
            Console.WriteLine("interface 1 Substraction......");
        }
         void B.sub()
        {
            Console.WriteLine("interface 2 Substraction......");
        }
    }
    class Inter_demo
    {
        static void Main(string[] args)
        {
            unit u = new unit();
            B uu = new unit();
            uu.Add();
            uu.sub();
            u.Add();
            u.sub();
        }
    }
}
