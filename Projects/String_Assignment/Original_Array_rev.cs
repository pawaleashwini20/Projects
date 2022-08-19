using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.String_Assignment
{
    class Original_Array_rev
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 4,5, 6, 78, 9 };
            Console.WriteLine(String.Join(" ",arr ));
            int i = 0;
            int j = arr.Length - 1;
            while (i < j)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;
                j--;
            }
            Console.WriteLine("\\\\\\\\\\\\\\\\\\");
            Console.WriteLine(String.Join(" ", arr));
        }
    }
}
