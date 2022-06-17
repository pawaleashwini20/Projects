using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Abstract_Demo
{
    abstract class Animal
    {
        public int x = 10;
        public static int y = 200;
        public Animal()       //Constructor
        {
            Console.WriteLine("Animal class Constructoe...");
        }
        public abstract void show();//Abstract method
        public void Myanimal()//concrete Method
        {
            Console.WriteLine("Myanimal...");
        }
    }
        class Dog:Animal//Dog class inherit Animal
        {
        public Dog():base()//Dog class constructor
        {
            Console.WriteLine("Dog constructor...");
        }

        public  override void show()//override parent class  abstract method
            {
            Console.WriteLine("override show method...");
            }
        
         }
    class AbstractDemo
    {
        static void Main(string[] args)
        {
            Animal a = new Dog();//
            a.show();
            a.Myanimal();
        }
    }
}
