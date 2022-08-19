using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    abstract class Mobiles
    {
        public abstract void music();
        public abstract void camera();
        public void Add()
        {
            Console.WriteLine("Addition...");
        }
    }
    class phone : Mobiles 
    {
        public override void music()
        {
            Console.WriteLine("Music");

        }
        public override void camera()
        {
            Console.WriteLine("Camera..");
        }
        public void Add()
        {
            Console.WriteLine("Addition....");
        }
    }
    class Demo_Abstract
    {
        static void Main(string[] args)
        {
            phone p = new phone();
            p.music();
            p.camera();
            p.Add();
        }
    }
}
