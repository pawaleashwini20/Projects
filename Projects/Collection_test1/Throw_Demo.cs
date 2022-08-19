using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Collection_test1
{
    public class My
    {
        public static void method()
        {
            try
            {
                throw new ArithmeticException();
            }
            catch(ArgumentException e)
            {

               Console.WriteLine("catch...");
               // throw e;//rethrow..
            }
        }

    }
        class Throw_Demo
        {
            static void Main(string[] args)
            {

                try
                {
                    My.method();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception" + e.Message);
                }
            }
        }
    
}
    


