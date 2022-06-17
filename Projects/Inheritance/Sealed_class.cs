using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Inheritance
{
    class laser
    {
        public int x = 10;
       // public sealed void show()
        public  virtual void show()
        {
            Console.WriteLine("Laser called..");
        }
    }
    class Office : laser 
    {
        public override void show()
        {
            Console.WriteLine("Office call...");      
        }
    }
    class Sealed_class
    {
        static void Main(string[] args)
        {
            Sealed_class s = new Sealed_class();
            laser l = new Office();
           

            l.show();
        }

    }
}
