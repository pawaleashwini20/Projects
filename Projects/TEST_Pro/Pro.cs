using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.TEST_Pro
{
    class Pro
    {
        static void Main(string[] args)
        {
            int[][] a = new int[2][];
            a[0] = new int[4] { 6, 1, 4, 3 };
            a[1] = new int[3] { 9, 2, 7 };
            Console.WriteLine(a[1].GetUpperBound(0));
        }
    }
}
