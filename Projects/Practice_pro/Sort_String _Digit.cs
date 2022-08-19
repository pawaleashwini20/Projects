using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    class Sort_String__Digit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string:");
            String s=Console.ReadLine();
            Console.WriteLine("String :"+s);
            char[] ch=s.ToCharArray();
            char[] ch_n = new char[s.Length];
            char[] ch_n1 = new char[s.Length];
            int n = 0;
            int j = ch.Length-1;
            char temp ;
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] >= '0' && ch[i] <= '9')
                {
                    ch_n[n] = ch[i];
                    n++;
                    //Console.WriteLine(ch[i]+" ");
                }
                 else if (ch[i] >= 'A' && ch[i] <= 'Z' || ch[i] >= 'a' && ch[i] <= 'z')
                { 
                        ch_n1[i] = ch[i];
                        n++;
                 }
                
                else
                {
                    ch_n1[n]++;
                    n++;
                }
            }

            Console.WriteLine(String.Join(" ", ch_n));
            Console.WriteLine("/////////////////////");
            Array.Sort(ch_n);
           
            Console.Write(String.Join("",ch_n));
           Console.Write(String.Join("", ch_n1));
        }
    }
}
