using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    class Remove_Duplicates_string
    {
        static void Main(string[] args)
        {
            // String s = "AshAwini";
            String s = "sameer";
            char[] ch = s.ToCharArray();
            char[] merge = new char[ch.Length];
            int k = 0;
            for (int i = 0; i < ch.Length; i++)
            {
                bool ispresent = true;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (ch[i] == ch[j])
                    {
                        ispresent = false;
                        break;
                    }
                }
                if (ispresent == true)
                {
                    merge[k] = ch[i];
                    k++;
                }
            }
            for (int i = 0; i < k; i++)
            {
                Console.Write(merge[i]+"");
            }
        }
    }
}
