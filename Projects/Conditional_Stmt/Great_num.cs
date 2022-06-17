using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Conditional_Stmt
{
    class Great_num
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter Three Number:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            if ((n1 > n2) && (n1 > n3))
            {
                Console.WriteLine("Greater is:" + n1);

            }
            else if ((n2 > n1) && (n2 > n3))
            {
                Console.WriteLine("Greater is:" + n2);
            }
            else 
            {
                Console.WriteLine("Greater is:" + n3);
            }
        }
    }
}
