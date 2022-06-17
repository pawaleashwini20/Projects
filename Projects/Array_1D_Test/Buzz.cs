using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Array_1D_Test
{
    class Buzz
    {
        static void Main(string[] args)
        {
            int cnt_b = 0, cnt_f = 0,cnt=0;
            for (int i= 1; i <= 50; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("buzzfizz" + "  ");
                    cnt++;
                }
                else if (i % 5 == 0)
                {
                    Console.Write("fizz" + "  ");
                    cnt_f++;
                }
                else if (i % 3 == 0 )
                {
                    Console.Write("buzz"+"  ");
                    cnt_b++;
                }
                else
                {
                    Console.Write(i + " ");
                }

            }
            Console.WriteLine("\nbuzz:"+cnt_b  +" \nfizz:"+cnt_f+"\nbuzzfuzz:"+cnt);

        }
    }
}
