using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    class Min_digit
    {
		static void Main(String[] args)
			{
				Console.WriteLine("Enter Number:");
				int n = int.Parse(Console.ReadLine());
				int min = 0;
				int rem;
				int cnt = 0;
				while (n > 0)
				{
					rem = n % 10;

					if (min > rem)
					{
						min = rem;
					}
					n = n / 10;
				}
				Console.WriteLine();

			}

		}

	}

