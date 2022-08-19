using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    interface Inter1
    {
        public void add();
    }
    interface Inter2
    {
        public void add();
        public void mult(int a, int b);
    }
    class Addition : Inter1, Inter2 
    {
        void Inter1.add()
        {
            Console.WriteLine("Inter1.......");
        }
         void Inter2.add()
        {
            Console.WriteLine("Inter2 method......");
        }
        public void mult(int a, int b)
        {
            Console.WriteLine(a*b);
        }
    }
    class Interface_demo
    {
        static void Main(string[] args)
        {
            int a = 10, b = 2;
            Addition ad = new Addition();
            Inter1 aa = new Addition();
            aa.add();
            Inter2 bb = new Addition();
            aa.add();
            ad.mult(a, b);
           
        }
    }
}
