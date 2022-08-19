using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    class String_repeat
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String:");
            String s = Console.ReadLine();
         // String s="Ashwini";
            char[] ch = s.ToCharArray();
            char[] merge = new char[ch.Length];
            //bool isvisit = true;
            int k = 0;
            for (int i = 0;i < ch.Length;i++)
            {
                bool isvisit = true;
                for (int j = i-1;j>=0;j--)
                {
                    if (ch[i] == ch[j])
                    {
                        isvisit = false;
                        break;
                    }
                }
                if(isvisit == true)
                {
                    merge[k] = ch[i];
                    k++;

                }
            }
            for (int m=0;m<k;m++)
            {
                Console.Write(merge[m]+"");
            }
        }
    }
}
