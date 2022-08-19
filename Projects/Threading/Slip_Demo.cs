using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace Projects.Threading
{
    class Slip_Demo
    {
        public static void m1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("I Am: "+i);
                Thread.Sleep(100);
            }
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(m1);
            t1.Start();
           // t1.Join();
            for (int i = 200; i < 215; i++)
            {
               
                Console.WriteLine(i);
            }
        }
    }
}
