using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    class Test
    {
        public void Count(int num)
        {
            int cnt = 0;
            int rem = 0;

            while (num > 0)
            {
                rem = num % 10;
                cnt++;
                num = num / 10;
            }
            Console.WriteLine("digits is:"+cnt);
        }
        static void Main(String[] args)
        {
            Console.WriteLine("Enter number:");
            int n = int.Parse(Console.ReadLine());
            Test t = new Test();
            t.Count(n);

        }
    }
}
