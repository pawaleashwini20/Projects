using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Inheritance
{
    class Laptop
    {
       protected int price = 45000;
    }
    class Dell : Laptop
    {
        public void show()
        {
            // price = 50000;
            Console.WriteLine("Dell Price:"+price);
        }
    }
    class Hp : Laptop 
    {
        public void show()
        {
            price = 55555;
            Console.WriteLine("Hp Price:"+price);
        }
    }
    class Accer : Laptop
    {
        public void show()
        {
            price = 65000;
            Console.WriteLine("Accer price:"+price);
        }
    }
    class MyLaptops
    {
        static void Main(string[] args)
        {
            Accer a = new Accer();
            a.show();
            Hp h = new Hp();
            h.show();
            Dell d = new Dell();
            d.show();
          
        }
    }
}
