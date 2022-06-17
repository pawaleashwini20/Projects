using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Test_loop_1
{
    class Tress_op3
    {
        static void Main(string[] args)
        {
			int i = 1;
			while (i <= 5)
			{
				int j = 1;
				while (j <= 5)
				{
					if (j == 2)
					{
						break;
						Console.WriteLine(j);
					}
					j++;
				}
				Console.WriteLine(i);
			}


		}
	}
}
