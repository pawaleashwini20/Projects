using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Strings
{
    class Revserse_Except_first
    {
        public void input(String str)
        {
            Console.WriteLine("String is:"+str);
            String rev = " ";
            int l = str.Length;

            for (int i =0; i<l; i++)
            {
                
                        rev = rev + str[i];
                
            
                
            }
            Console.WriteLine("Reverse string : "+rev);
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
