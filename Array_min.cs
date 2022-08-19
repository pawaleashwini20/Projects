using System;
class Array_min
{
	public void Max(int[] arr1)
	{
		int max=arr1[0];
		for(int i=0;i<arr1.Length;i++)
		{
			if(arr1[i]>max)
			{
				max=arr1[i];
			}
		}
		Console.WriteLine("max is:"+max);
	}
	public void Min(int[] arr1)
	{
		int min=arr1[0];
		for(int i=0;i<arr1.Length;i++)
		{
			if(arr1[i]<min)
			{
				min=arr1[i];
			}
		}
		Console.WriteLine("Min is:"+min);
	}

	public static void Main(String[] args)
	{
		Console.WriteLine("Enter Array Size:");
		int n=int.Parse(Console.ReadLine());
		int[] arr=new int[n];
		Console.WriteLine("Enter Array element");
		for(int i=0;i<arr.Length;i++)
		{
			arr[i]=int.Parse(Console.ReadLine());
		}
		Array_min a=new Array_min();
		a.Max(arr);
		a.Min(arr);
	 
	}
}