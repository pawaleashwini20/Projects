using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Collections
{
    class Fact_Delegate
    {
        delegate int a(int n);
        static void Main(string[] args)
        {
            
                int fact = 1;
                a delobj = y =>
                {
                    for (int i = 1; i <= y; i++)
                    {
                        fact = fact * i;
                    }
                    return fact;
                };
                Console.WriteLine("\n Enter A Number: ");
                int b = Convert.ToInt32(Console.ReadLine());
                int c = delobj(b);
              //  Console.WriteLine("\n The Factorial Of The number {0} is {1}", b, c);
                Console.WriteLine("Fact is :"+c);
            

        }
    }
}
