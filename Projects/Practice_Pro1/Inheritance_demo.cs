using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_Pro1
{
    class Animal
    {
        public virtual void pet()
        {
            Console.WriteLine("Animal class pet method");
        }
        public virtual void Monkey()
        {
            Console.WriteLine("Animal class Monkey method.");
        }
    }
    class Dog : Animal 
    {
        public override void pet()
        {
            base.pet();
            Console.WriteLine("Dog class Peth method..");
        }
    }
    class Add_all : Dog
    {
        public override void  pet()
        {
            Console.WriteLine("Add_All class method Pet");
        }
        public void king()
        {
            Console.WriteLine("King method of class Add_all");
        }
    }
    class Inheritance_demo
    {
        static void Main(string[] args)
        {
           // Add_all aa = new Add_all();
            //aa.pet();
            //aa.king();
            //aa.Monkey();
            Dog d = new Dog();
            d.pet();
        }
    }
}
