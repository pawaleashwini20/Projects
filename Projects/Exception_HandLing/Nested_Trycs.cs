using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Exception_HandLing
{
    class Nested_Trycs
    {
        static String n;
        static void Main(string[] args)
        {
            int num = 0;

            Console.WriteLine("Enter 2 Numbers:");
            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Division:" + a / b);
                Console.WriteLine("Try Ends....");
                try
                {
                    String str = "";
                    Console.WriteLine("Enter age:");
                    int age = int.Parse(Console.ReadLine());
                    Console.WriteLine("age is:" + age);
                    Console.WriteLine(n.ToLower());
                }
                catch (NullReferenceException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("Try Ends....");
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
