using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Interface_demo
{
    interface Imobile
    {
        void sim();
      
    }
    abstract class Vmobile
    {
        public abstract void music();
    }
    interface Smobile
    {
        void camera();
    }
    class Model : Vmobile,Imobile, Smobile//multiple inheritance
    {
        public void sim()    //always abstract method no need to add abstract keyword
        {
            Console.WriteLine("interface sim");
        }
        public void camera()
        {
            Console.WriteLine("interface camera");
        }
       public override void music()
        {
            Console.WriteLine("abstract class method music");
        }

    }
    class Interface_main 
    {
        static void Main(string[] args)
        {
            Model m = new Model();
            m.sim();
            m.camera();
            m.music();
        }
    }
}
