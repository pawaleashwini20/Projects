using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Strings
{
    class Revserse_Except_first
    {
        public void input(String str1)
        {
            Console.WriteLine("String is:"+str1);
            char[] str = str1.ToCharArray();
            String rev = " ";
            int j = str1.Length-2;
            int i = 1;
            while (i < j)
            {
                char temp = str[i];
                str[i] = str[j];
                str[j] = temp;
                i++;
                j--;
            }
            Console.WriteLine("Reverse string : "+str);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String :");
            String s = Console.ReadLine();
            Revserse_Except_first r = new Revserse_Except_first();
            r.input(s);
        }
    }
}
