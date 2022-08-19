using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.TEST_Pro
{
    class AP
    {
      
            static void Main(string[] args)
            {
                int a2 = Convert.ToInt32(Console.ReadLine());
                int a3 = Convert.ToInt32(Console.ReadLine());
                int n = Convert.ToInt32(Console.ReadLine());
                int diff = a3 - a2;

                for (int i = 3; i < n; i++)
                {
                    a3 = a3 + diff;
                }
                Console.WriteLine(a3);
            }
        }
    }

