using System;
class Practice
{
	public static void Main(String[] args)
	{
		Console.WriteLine("Hello Word...");
		int[] arr={1,2,4,2,-1,8,9,0,10};
		Console.WriteLine("Array is");
		for(int i=0;i<arr.Length;i++)		
		{
			Console.Write(arr[i]+" ");	
		}
		int max=arr[0];
		for(int i=0;i<arr.Length;i++)
		{
			if(arr[i]>max)
			{
				max=arr[i];
			}
		}
		Console.WriteLine("\nMax is:"+max);
		int min=arr[0];
		//Console.WriteLine("");
		for(int i=0;i<arr.Length;i++)
		{
			if(arr[i]<min)
			{
				min=arr[i];
			}
		}
		Console.WriteLine("Min is:"+min);
	}
}