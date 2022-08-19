using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Exception_HandLing
{
    class First_Pro
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Number:");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter 2 num");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Division:"+a/b);
                Console.WriteLine("Try ends...");
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("1..");
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("2..");
                Console.WriteLine(e.Message);
            } 
            catch (SystemException e)//Universal Exception always at the end..
            {
                Console.WriteLine("3..");
                Console.WriteLine(e.Message);
            }
            for (int i = 1; i < 10; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
