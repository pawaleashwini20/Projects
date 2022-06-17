using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Inheritance
{
    class Animal
    {
       public String name;
        public void Display()
        {
            Console.WriteLine("Animal...");
        }
    }
    class Dog1 : Animal
    {
        public void getname()
        {
            Console.WriteLine("Name is:" + name);
        }
    }
    class Single1
    {
        static void Main(string[] args)
        {
            Dog1 d = new Dog1();
            d.name = "Dooggii";
            d.Display();
            d.getname();
            Console.ReadLine();
        }
    }
}
