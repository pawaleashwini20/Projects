using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Inheritance
{
    class Animals
    {
        protected int legs = 4;
        public Animals()
        {
            Console.WriteLine("Animals from Animal class...");
        }
        public Animals(int x)
        {
            Console.WriteLine("x from Animal x="+x);
        }
        public void foo()
        {
            Console.WriteLine("parents foo from Animal class..");
        }
    }
    class Dog:Animals
    {
        int legs = 2;
        public Dog()
        {
            Console.WriteLine("Dog from Dog class..");
        }
        public Dog(int x):base(x)
        {
            Console.WriteLine("my x child from dog class:"+x);
        }
        public void foo()
        {
            Console.WriteLine("child from dog class..");
        }
        public void show()
        {
            Console.WriteLine(legs+" "+base.legs);
        }
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.show();
            d.foo();
            Dog d1 = new Dog(100);
        }
    }
}
