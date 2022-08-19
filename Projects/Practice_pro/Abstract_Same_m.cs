using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    abstract class Abstract_D
    {
        public Abstract_D()
        {
            Console.WriteLine("Abstract_D constructor.....");
        }
        public abstract void Add();
        public abstract void Sub(int a,int b);
        public abstract void Add(int a);
    }
    interface Interface_D
    {
        public void Mult(int a,int b);
    }
    class Add_Class:Abstract_D,Interface_D
    {

        public void Mult(int a,int b)
        {
            Console.WriteLine("Multiplication:"+a*b);
        }
        public override void Add()
        { 
            Console.WriteLine("Addition..");
        }
        public override void Sub(int a, int b)
        {
            Console.WriteLine("Substraction:"+(a-b));
        }
        public override void Add(int a)
        {
            Console.WriteLine("A is:"+a);
        }
    }
    class Abstract_Same_m
    {
        static void Main(string[] args)
        {
            Add_Class a = new Add_Class();
            a.Mult(10, 20);
            a.Sub(10, 90);
            a.Add();
            a.Add(100);
        }
    }
}
