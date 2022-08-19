using System;
class Cuckoo
{
	int coo(int s)
	{
		if(s==0)
		{
			s=0;
		}
		if(s==1)
		{
			s=1;
		}
		return s;
	}
	public static void Main(String[] args)
	{
		Cuckoo ck=new Cuckoo();
		Console.WriteLine("Enter number:");
		int n=Convert.ToInt32(Console.ReadLine());
		int c=0;
		if(n==1)
		{
			Console.WriteLine("0");
		}
		else if(n==2)
		{
			Console.WriteLine("1");
		}
		else if(n>2)
		{
			c=1*ck.coo(n-1)+2*ck.coo(n-2)+3*1;
			Console.WriteLine(c);
		}
	}
}