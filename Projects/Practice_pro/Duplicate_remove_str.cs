using System;
using System.Collections.Generic;
using System.Text;
//remove duplicate from array converting string to array
namespace Projects.Practice_pro
{
    class Duplicate_remove_str
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String:");
            String s = Console.ReadLine();
            Console.WriteLine("Enter Second Strng");
            String s1 = Console.ReadLine();
            String str = s + s1;
            Console.WriteLine("Srting is:"+str);
            char[] ch = str.ToCharArray();
            char[] merge = new char[ch.Length];
            int k=0;
            for (int i = 0; i < ch.Length; i++)
            {
                bool isvisite = true;
               for(int j=i+1;j<ch.Length;j++)
               // for (int j = i-1; j >= 0; j--)
                {
                    if (ch[i] == ch[j])
                    {
                        isvisite = false;
                        break; 
                    }
                }
                if (isvisite ==true)
                {
                    merge[k] = ch[i];
                    k++;
                }
            }
             Console.WriteLine(String.Join(" ",merge));
           /* for (int i = 0; i < k; i++)
            {
                Console.Write(merge[i]+" ");
            }*/
        }
    }
}
