using System;
class Coprime
{
	public static void Main(String[] args)
	{
		Console.WriteLine("Enter Number:");
		int n=Convert.ToInt32(Console.ReadLine());
		int gcd=0;
		int c=0;
		for(int i=1;i<n;i++)
		{
			for(int j=i+1;j<i;j++)
			{
				if(i%j==0 &&n%i==0)
				{
					gcd=j;
				}
			}
				if(gcd==1)
				{
					c++;
				}
		}
		Console.WriteLine(c);

	}
} 