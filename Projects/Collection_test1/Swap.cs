using System;
using System.Collections.Generic;
using System.Text;
//3.	WAP of swap two elements in an List
namespace Projects.Collection_test1
{
   public static class Swapping
    {
        public static void swapp<t>(this List<t> list, int i, int j)
        {
            (list[i], list[j]) = (list[j], list[i]);
        }
    }
    class Swap 
    { 
        static void Main(string[] args)
        {
            List<int> ll = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (int p in ll)
            {
                Console.WriteLine(p);
            }
            // Swapping s = new Swapping();
            Console.WriteLine("After Swap:");
            ll.swapp(2, 3) ;
            Console.WriteLine(String.Join(' ',ll));
        }
    }
}
