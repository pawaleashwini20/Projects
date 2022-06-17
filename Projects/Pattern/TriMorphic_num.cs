using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Pattern
{
    class TriMorphic_num
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number to Check:");
            int n = int.Parse(Console.ReadLine());
            int cube = n * n * n;
            int n2 = n;
            int flag = 0;
            Console.WriteLine("cube is:"+cube);
            while (n2!= 0)
            {
                if (n2 % 10 != cube % 10)
                {
                    flag = 1;
                    break;
                }
                n2 = n2 / 10;
                cube = cube / 10;
            }
            if (flag == 0)
            {
                Console.WriteLine("trimorphic number");
            }
            else 
            {
                Console.WriteLine("Not trimorphic");
            }
        }
    }
}
