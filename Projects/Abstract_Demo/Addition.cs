using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Abstract_Demo
{
    interface Int1          //interface
    {
       static int x;
        void show();
    }
    abstract class absrt1                 //abstract class
        {
                    public abstract void input();           //abstract mehtod
        }
    class Merge: absrt1,Int1
    {
        public void show()
        {
            Int1.x = 100;
           Console.WriteLine("x: "+Int1.x);
        }
        public override void input()
        {
            int y = 200;
            Console.WriteLine("y: "+y);
            int n = Int1.x + y;
            Console.WriteLine("sum is: " + n);
        }

    }
    class Addition
    {
        static void Main(string[] args)
        {
            Merge a = new Merge();
            a.show();
            a.input();
        }


    }
}
