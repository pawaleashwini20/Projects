using System;
using System.Collections.Generic;
using System.Text;
//number last digit and square last digit same i.e 5=5*5=25  6=6*6=36  
namespace Projects.Test_loop_1
{
    class Automorphic_num
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int n = int.Parse(Console.ReadLine());
            int temp = n;
            int cnt = 0;
            int sq = n * n;
            while (n > 0)
            {
                cnt++;
                n = n / 10;
            }
            Console.WriteLine("count is:" + cnt);
            int power = 1;
            while (cnt > 0)
            {
                power = power * 10;
                cnt--;
            }
            Console.WriteLine("power:" + power);
            n = temp;
            int end = sq % power;
            if (n == end)
            {
                Console.WriteLine("Automorphic number...");
            }
            else
            {
                Console.WriteLine("Not Automorphic number...");
            }
        }
    }
}
