using System;
using System.Collections.Generic;
using System.Text;
//4.	Create an array of 10 names sort in descending order
namespace Projects.String_Assignment
{
    class Name_str_sort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name:");
            string[] s =new string[10];
            for(int i=0;i<10;i++)
            {
                String x = Console.ReadLine();
                s[i] = x;
            }
            Array.Sort(s);
            for (int i = 0; i < 10; i++)
            {
                Console.Write(s[i]+" ");
            }
        }
    }
}
