using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Collections
{
    class Use_Lamda
    {
            static void m1(int a, float b)
            {
                Console.WriteLine("in m1" + (a + b));
            }
            static void m2(string msg)
            {
                Console.WriteLine("Welcome" + msg);
            }

            static int cube(int x)
            {
                return x * x * x;
            }
            static float AreaOfCircle(int r)
            {
                return 3.14f * r * r;
            }
            static bool isEven(int x)
            {
                return x % 2 == 0;
            }
            static void Main(string[] args)
            {
                Action<int, float> d1 = m1;
                d1(11, 2.3f);
                Action<string> d2 = m2;
                d2("Good Evening");


                Func<int, float> d3 = AreaOfCircle;
                float area = d3(5);

                Func<int, bool> d4 = isEven;
                Predicate<int> d5 = isEven;
            }
        }
    }