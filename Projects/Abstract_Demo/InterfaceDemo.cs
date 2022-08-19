using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Abstract_Demo
{
    
       public interface Imovable    //interface
        {
            static int x;   //static variable declaration
           abstract void show();    //abstract method
        void foo()      //concrete method
        {
            Console.WriteLine("foo method...");
        }
        static void Mymethod()//static method
            {
                Console.WriteLine("Mymethod from interface Imovable...");
            }
           
        }
    class car : Imovable //car class implements Imovable interface
    {
        public void show()//override abstract method
        {
                Imovable.x = 100;
            Console.WriteLine("Interface Imovable..." + Imovable.x);
        }
    }
    class InterfaceDemo
    {
        static void Main(string[] args)
        {
            Imovable m = new car();
            m.show();
            Imovable.Mymethod();
            m.foo();

        }
    }
}
