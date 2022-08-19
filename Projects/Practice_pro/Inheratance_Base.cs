using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    class Mobiles1
    {
        public virtual void Iphone()
        {
            Console.WriteLine("Parent class Iphone Method...");
        }
    }
    class Mobiles2:Mobiles1
    {
        public override void Iphone()
        {
            Console.WriteLine(" Mobile class 2Child class Iphone Method...");
        }
    }
    class Mobiles3 : Mobiles2
    {
        public override void Iphone()
        {
            Console.WriteLine("Mobile class 3");
        }
    }
    class Inheratance_Base
    {
        static void Main(string[] args)
        {
            Mobiles1 m2 = new Mobiles1();
            m2.Iphone();
            Mobiles1 m1 = new Mobiles2();
            m1.Iphone();
            Mobiles1 m = new Mobiles3();
            m.Iphone();

        }
    }
}
