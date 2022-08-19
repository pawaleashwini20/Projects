using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Projects.Exception_HandLing
{
    class Finally_Block
    {
        static void Main(string[] args)
        {
            StreamReader sr = null;
            try
            {
                Console.WriteLine("Enter nummber:");
                int a = int.Parse(Console.ReadLine());
                sr = new StreamReader("D://a.txt");
                Console.WriteLine(sr.Read());
                Console.WriteLine(sr.ReadLine());

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("in finally....");
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }
    }
}
