using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    class Animal
    {
        public virtual void pet()
        {
            Console.WriteLine("Animal class Pet method...");
        }
        public virtual void money()
        {
            Console.WriteLine("Money method of class Animal");
        }
        public virtual void Dogii()
        {
            Console.WriteLine("Animal class Dogii Method..");
        }
    }
    class Cow:Animal
    {
        public override void pet()
        {
            Console.WriteLine("cow class pet Method...");
        }
    }
    class Dog:Cow
    { 
       
        public override void pet()
        {
            base.pet();
            Console.WriteLine("Dog class pet method..");
        }
        public override void Dogii()
        {
            Console.WriteLine("Dog class Dogii Method..");
        }
    }

    class Add_all:Dog
    {
        public override void pet()
        {
            Console.WriteLine("Add_All class pet method");
        }
        public override void Dogii()
        {
            Console.WriteLine("Dog class Dogii Method..");
        }
    }
    class Inheritance_Same_M
    {
        static void Main(string[] args)
        {
            Add_all a = new Add_all();
            a.pet();
            a.money();
            a.Dogii();
           Cow c = new Add_all();
           c.pet();
           c.Dogii();
        //    Animal n = new Animal();
          //  n.pet();
           // n.Dogii();
        //    Dog d = new Add_all();
         //   d.pet();
          //  d.Dogii();
        }
    }
}
