using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    class String_op
    {
        public void reverse(String s)
        {
            string rev = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                rev=rev+s[i];
            }
            Console.WriteLine("Reverse is:"+rev);
        }
        public void palindrom(String s)
        {
            String rev = "";
            for (int i = s.Length-1; i >= 0; i--)
            {
                rev = rev + s[i];
            }
            Console.WriteLine("Reverse is:"+rev);
            if (s.Equals(rev))
            {
                Console.WriteLine("Palindrom");
            }
            else 
            {
                Console.WriteLine("Not Palndrom");
            }
        }
        public void Word_cnt(String s)
        {
            String[] s1 = s.Split(" ");
            int cnt = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != "\n" || s1[i] != " " || s1[i] != "\t")
                {
                    cnt++;
                }
            }
            Console.WriteLine("Count is:"+cnt);
        }
        public void Frequency(String s)
        {
            char[] ch = s.ToCharArray();
            int[] freq = new int[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                freq[i] = 1;
                for (int j = i + 1; j < s.Length; j++)
                {
                    if(ch[i] == ch[j])
                        {
                        freq[i]++;
                        ch[j] = '0';
                        }
                }
            }
            for (int i = 0; i < freq.Length; i++)
            {
                if (ch[i] != '0' && ch[i] != ' ')
                {
                    Console.WriteLine(ch[i]+" : "+freq[i]);
                }
            }
        }
        public void owel(String s)
        {
            char[] ch = s.ToCharArray();
            Console.WriteLine("Owels Are:");
            for (int i = 0; i < s.Length; i++)
            {
              
                if(ch[i]=='a'||ch[i]=='e'||ch[i]=='i'||ch[i]=='o'||ch[i]=='u')
                {
                    Console.WriteLine(ch[i]+" ");
                }
            }
        }
        //A=97
        //a=65
        public void Upper(String s)
        { 
            char[] ch=s.ToCharArray();
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] > 64 || ch[i] < 91)
                {
                    ch[i] = (char)(ch[i] + 32);
                  
                }

               else if (ch[i] > 96 || ch[i] <122)
                    {
                        ch[i] = (char)(ch[i] - 32);
                    }
                     
                
            }
         /*   for (int i = 0; i < ch.Length; i++)
            {
                Console.Write(ch[i]);
            }*/
        }
        static void Main(string[] args)
        {
            String_op s = new String_op();
            Console.WriteLine("Enter String:");
            String str = Console.ReadLine();
            s.reverse(str);
            s.palindrom(str);
            s.Word_cnt(str);
            s.Frequency(str);
            s.owel(str);
           // s.Upper(str);
        }
    }
}
