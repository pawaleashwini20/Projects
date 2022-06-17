using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.While
{
    class Odd_square_series
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter number:");
            int num = int.Parse(Console.ReadLine());
            int i=1;
           // int cnt=0;
            while (i<num)
            {
                Console.WriteLine(" " + ((i % 2 == 0) ? i : (i * i)));
                i++;
               // Console.WriteLine(sq);
            }
           
        }
    }
}
