using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Test_Paper15_aug
{
    class Freq_Each_Digit
    {
		public void occurrence(int number, int[] result)
		{
			int temp = 0;
			while (number != 0)
			{
				temp = number % 10;
				if (temp < 0)
				{
					temp = -temp;
				}
				result[temp]++;
				number /= 10;
			}
		}
		public void frequency(int number)
		{
			int[] result = new int[10];
			//Set initial frequency of digit
			for (int i = 0; i < 10; i++)
			{
				result[i] = 0;
			}
			Console.Write("\nNumber : " + number + "");
			occurrence(number, result);
			for (int i = 0; i < 10; i++)
			{
				if (result[i] != 0)
				{
					Console.Write("\n " + i + " : " + result[i] + "");
				}
			}
			Console.Write("\n");
		}
		public static void Main(String[] args)
		{
			Freq_Each_Digit obj = new Freq_Each_Digit();
            Console.WriteLine("Enter number:");
			int n=int.Parse(Console.ReadLine());
			obj.frequency(n);
		}

		}
	}
