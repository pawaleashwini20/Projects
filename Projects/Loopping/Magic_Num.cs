using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Loopping
{
    class Magic_Num
    {
        static void Main(string[] args)
        {
             int MagicN = 45;  
            for (; ; )
            {
                Console.WriteLine("Enter Number:");
                int num = int.Parse(Console.ReadLine());
                if (num < MagicN)
                {
                    Console.WriteLine("Number is less than Magic number.");
                    continue;
                }
                else if (num > MagicN)
                {
                    Console.WriteLine("Number is Greater than Magic number.");
                    continue;
                }
                else
                {
                    Console.WriteLine("Number u Enter is Magic number.");
                    break;
                }
            }
        }
    }
}
