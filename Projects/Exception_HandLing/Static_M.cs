using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Exception_HandLing
{
    //Exception Propagation   
    class Static_M
    {
        static void m1()
        {
            Console.WriteLine("Enter Age:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("m1 ends here....");
        }
        static void m2()
        {
            m1();
            Console.WriteLine("In m2 method......");
        }
        static void Main(string[] args)
        {
            try
            {
                m2();
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Main Ends Here....");
        }
    }

}
