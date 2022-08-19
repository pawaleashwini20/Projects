using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Projects.Threading
{
    class Priority
    {
        public static void m1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Odd:"+i+Thread.CurrentThread.Name);
            }
        }
        static void Main(string[] args)
        {
            /*Thread mn=Thread.CurrentThread;
            Thread t1 = new Thread(m1);
            Console.WriteLine( "Priority.."+t1.Priority);
            Thread t2 = new Thread(m1);
            t2.Name = "Ashu..";
            t2.Priority=ThreadPriority.Highest;
            t1.Start();
            t2.Start();*/
            Console.WriteLine("///////////////////////");
            Thread t3 = new Thread( m1);
            t3.IsBackground = true;//as helper
            t3.Start();
        }
    }
}
