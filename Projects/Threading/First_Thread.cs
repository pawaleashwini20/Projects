using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace Projects.Threading
{
    class First_Thread
    {
        static void m1()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main Starts...");
            Thread t1 = new Thread(m1);
            t1.Start();
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Good Morning.......");
            }
            Console.WriteLine("Main Ends..");

        }
    }
}
