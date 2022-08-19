using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_Pro1
{
    class Exception_Demo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 2 Number");
            try
            {
                int n = int.Parse(Console.ReadLine());
                int n1 = int.Parse(Console.ReadLine());
                int c = (n / n1);
                Console.WriteLine(c);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Always execute....");
            }
        }
    }
}
