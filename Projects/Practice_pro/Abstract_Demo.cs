using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    public abstract class AB
    {
        public abstract void add(int a, int b);
        public abstract void sub(int a, int b);
        public abstract void mult(int a, int b);
        public void div(int a, int b)
        {
            Console.WriteLine("Division:"+(a/b));
        }

    }
    class Add : AB
    {
        public override void add(int a, int b)
        {
            Console.WriteLine("Addition:"+(a+b));
        }
        public override void sub(int a, int b)
        {
            Console.WriteLine("Substraction:"+(a-b));
        }
        public override void mult(int a, int b)
        {
            Console.WriteLine("Multiplication:"+(a*b));
        }
    
    }
    class Abstract_Demo
    {
        static void Main(string[] args)
        {
            AB aa = new Add();//  add of ab_class=new parent
            int a = 10, b = 2;
            aa.add(a, b);
            aa.sub(a, b);
            aa.mult(a, b);
            aa.div(a, b);
        }
    }
}
