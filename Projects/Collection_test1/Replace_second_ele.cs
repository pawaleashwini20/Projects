using System;
using System.Collections.Generic;
using System.Text;

//4.	WAP to replace the second element of an List with the specified element
namespace Projects.Collection_test1
{
    class Replace_second_ele
    {
        static void Main(string[] args)
        {
            List<int> ll = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int i in ll)
            {
                Console.Write(i+" ");
            }
            ll.Insert(2,222);//(index number)
           // ll.SetByIndex(2, 9);
            foreach (int i in ll)
            {
                Console.Write(i+" ");
            }
            }
        }
    }

