using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Abstract_Demo
{
    //          Projects.Abstract_Demo.Ab_Main
    abstract class Mobile   //Abstract class
    {
        int i = 0;
       protected Mobile()//Constructor
        {
            Console.WriteLine("Constructor..parent class Mobole..");
        }
        public virtual void color()//non abstract method
        {
            Console.WriteLine("non abstract method....COLOR parent class");
        }
        public abstract void price();//abstract method..... always base class
       
    }
     class model123:Mobile
    {
       public model123():base()
        {
            Console.WriteLine("Model123....Constructor");
        }

        public override void price()
        {
            Console.WriteLine("Override Mobel123");
        }
        public void color()//:base()
        {
           base.color();
            Console.WriteLine("chlid class method color...");
        }
       
    }
    class Ab_Main
    {
        static void Main(string[] args)
        {
             Mobile m = new model123();
           // model123 m = new model123();
            m.price();
            m.color();
        }
    }
}
