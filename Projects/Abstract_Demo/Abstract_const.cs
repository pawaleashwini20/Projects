using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Abstract_Demo
{
    public abstract class Demo1
    {
        public Demo1()
        {
            Console.WriteLine("constructor Demo....");
        }
        public abstract void Abmethod();

    }

    class AB_Add :Demo1
    {
        public override void Abmethod()
        {
            Console.WriteLine("Abstract class Abstract method....");
        }

       
    }
    class Abstract_const
    {
        static void Main(string[] args)
        {
            AB_Add aa = new AB_Add();
            aa.Abmethod();
        }
    }
}

