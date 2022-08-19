using System;
class String_rev
{
	public void Rev(String s)
	{
		String rev="";
		for(int i=s.Length-1;i>=0;i--)
		{
			rev=rev+s[i];
		}
		Console.WriteLine(rev);	
	}

	public static void Main(String[] args)
	{
		Console.WriteLine("Enter String:");
		String s=Console.ReadLine();
		String_rev r=new String_rev();
		r.Rev(s);
	}
}