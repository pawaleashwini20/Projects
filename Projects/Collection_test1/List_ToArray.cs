using System;
using System.Collections.Generic;
using System.Text;

//6.	WAP to convert List to array.
namespace Projects.Collection_test1
{
    class List_ToArray
    {
        static void Main(string[] args)
        {
                 List<int> li = new List<int>();
                  li.Add(100);
                  li.Add(200);
                  li.Add(300);
                  li.Add(400);
                  li.Add(500);
                 int[] a =li.ToArray();
                  foreach(int i in a)
                  {
                      Console.WriteLine(i);

                  }
            }
        }
    
}

