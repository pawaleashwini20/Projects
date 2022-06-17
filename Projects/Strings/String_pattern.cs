using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Strings
{
    class String_pattern
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String:");
            String s = Console.ReadLine();
            String[] str = s.Split(" ");
            //int cnt = 0;
           
           for(int i=0;i<str.Length;i++)
            {
                for (int j = 0;j <=i; j++)
                {
                  
                        Console.Write(str[j]+" ");

                }
                Console.WriteLine(); 
            }
        }
    }
}
