using System;
using System.Collections.Generic;
using System.Text;
//cube of digit ens with same as given number
namespace Projects.Test_loop_1
{
    class Trimorphic_num
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number:");
            int n = int.Parse(Console.ReadLine());
            int n2 = n;
            int cube = n * n * n;
            int flage = 0;
            while (n2 != 0)
            {
                if (n2 % 10 != cube % 10)
                {
                    flage = 1;
                    break;
                }
                n2 = n2 / 10;
                cube = cube / 10;
            }
            if (flage == 0)
            {
                Console.WriteLine("Trimorphic..");
            }
            else
                Console.WriteLine("Not trimorphic..");
        }

    }
}
