using System;
class Large
{
	public static void Main(String[] args)
	{
		Console.WriteLine("Enter number:");
		int n=int.Parse(Console.ReadLine());
		int rem=0;
		int max=0;
		while(n>0)
		{
			rem=n%10;
			{
				if(rem>max)
				{
					max=rem;		
				}
			n=n/10;
			}
		}
		Console.WriteLine(max);	
	}
}