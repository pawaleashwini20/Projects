using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    interface I1
    {
        abstract void add();

    }
    interface I2
    {
        abstract void sub();
    }
    abstract class Ab1
    {
        public abstract void mult();
        public void simple2()
        {
            Console.WriteLine("Concrete method of abstract class..");
        }
    }
    class Common : Ab1, I1, I2
    {
       //simple1();
        public void add()
        {
            Console.WriteLine("override method if interface I1..");
        }
        public void sub()
        {
           
            Console.WriteLine("override method of interface I2..");
        }
        public override void mult()
        {
            base.simple2();
            Console.WriteLine("Override method of abstract class Ab1...");
        }

    }
    class Absract_Interface
    {
        static void Main(string[] args)
        {
            Common c = new Common();
            c.add();
            c.sub();
            c.mult();
            
        }
    }
}
