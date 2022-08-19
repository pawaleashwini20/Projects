using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.TEST_Pro
{
    class Demo
    { 
        public static void Main(String[] args)
            {
                char[] arr = new char[] { 'a', 'b', 'r' };
              /*    for(int i=0;i<arr.Length;i++)
                  {
                Console.WriteLine((char)i);
                  }*/
                foreach (int i in arr)
                {
                Console.WriteLine((char)i);
                }
            }


        }
}
