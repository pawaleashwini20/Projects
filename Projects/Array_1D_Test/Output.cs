using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Array_1D_Test
{
	class Output
	{
		public static void Main(String[] args)
		{
			int[] a1 = { 1, 2, 3 };

			int[] a2 = new int[a1.Length];
			for (int i = 0; i < a1.Length; i++)
			{
				a2[i] = a1[i];
			}
			for (int i = 0; i < a2.Length; i++)
			{

				Console.WriteLine(a2[i]);

			}
		}
	}
}
