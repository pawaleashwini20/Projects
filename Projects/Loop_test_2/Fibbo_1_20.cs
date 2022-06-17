using System;
using System.Collections.Generic;
using System.Text;
//4.	WAP to print fibbo series upto 20 terms
namespace Projects.Loop_test_2
{
    class Fibbo_1_20
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 1;
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            int sum = 0;
            for (int i = 1; i <= 20; i++)
            {
                sum = n1 + n2;
                Console.WriteLine(sum);
                n1 = sum;
                n1 = n2;
                n2 = sum;
            
            }
        }
    }
}
