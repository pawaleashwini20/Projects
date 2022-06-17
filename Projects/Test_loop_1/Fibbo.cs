using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Test_loop_1
{
    class Fibbo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int n=int.Parse(Console.ReadLine());
            int n1 = 0;
            int n2 = 1;
            int sum = 0; 
            //temp;
            Console.Write(n1+" ");
            Console.Write(n2+" ");
            for (int i = 0; i <= n; i++)
            {
                sum = n1 + n2 ;
                Console.Write(sum+" ");
                n1=sum;
                n1= n2;
                n2 = sum;

            }

        }
    }
}
