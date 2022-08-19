using System;
using System.Collections.Generic;
using System.Text;
/*
 when we create object of child class and use base() keyword to call parent class method 
 all methods of child class and parent class call.
 but when we create  parent class object only parent class methods call.
 */
namespace Projects.Practice_pro
{
    //  Projects.Practice_pro.Abstract_mobile
    abstract class Mobile1
    {
        protected Mobile1()
        {
            Console.WriteLine("Mobile1 Constructor..");
        }
        public virtual void color1()
        {
           
            Console.WriteLine("Color1 method of parent..");
        }
        public abstract void price1();
    }
    class Model222 : Mobile1
    {
        public Model222():base()
            {
            Console.WriteLine("Model222  constructor...");
            }
        public void color1()
        {
            base.color1();
            Console.WriteLine("color1 method of Model222 class...");
        }
        public override void price1()
        {
            Console.WriteLine("Price1 override  method ...");
        }
    }
    class Abstract_mobile
    {
        static void Main(string[] args)
        {
           Mobile1 mm = new Model222();
         // Model222 mm = new Model222();
            mm.price1();
             mm.color1();
          
        }
    }
}
