using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    class Remove_Duplicates
    {
        public void check(String s)
        {
            char[] ch = s.ToCharArray();
            int k = 0;
            char[] merge = new char[ch.Length];
            for (int i = 0; i < ch.Length; i++)
            {
                bool ispresent = true;
                for (int j = i - 1; j >=0; j--)
                {
                    if (ch[i] == ch[j])
                    {
                        ispresent = false;
                        break;
                    }
                }
                if (ispresent ==true)
                {
                    merge[k]=ch[i];
                    k++;
                }

            }
            for (int i = 0; i < k; i++)
            {
                Console.Write(merge[i]+" ");
            }
        }
            static void Main(string[] args)
            {
                Console.WriteLine("Enter String:");
                String s = Console.ReadLine();
            Remove_Duplicates r = new Remove_Duplicates();
            r.check(s);
            }
        
    }
}
