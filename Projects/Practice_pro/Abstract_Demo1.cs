using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    // Projects.Practice_pro.Abstract_Demo1
    abstract class Mobile   // abstract class
        {
            int x = 100;

            protected Mobile()   //constructor
            {
                Console.WriteLine("Mobile Constructor..");
            }
           public void color()   //concrete method
            {
                Console.WriteLine("non abstract m Mobile class....color method");
            }
            public abstract void price();//abstract method
        }
        class Model123 : Mobile
        {
            public Model123()   //model123 constructor
            {
                
                Console.WriteLine("Model123 Constructor....");
            }
            public override void price()  //override method
            {
                Console.WriteLine("Override Method of Mobile class...");
            }
            public void color()//:base()
            {
               base.color();
                Console.WriteLine("Model123 class....color method....");
            }

        }
    class Abstract_Demo1
    {
        static void Main(string[] args)
        {
          // Mobile m = new Model123();
            Model123 m = new Model123();
            // m.color();
            m.color();
            m.price();
        }
    }
}
