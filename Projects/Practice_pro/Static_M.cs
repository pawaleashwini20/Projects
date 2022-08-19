using System;
using System.Collections.Generic;
using System.Text;
/*
 * we cannot inherit static class
 * we cannot create object of static class
 */
namespace Projects.Practice_pro
{
     class Stat
    {
        static void Add()
        {
            Console.WriteLine("Static method Add111...");
        }
    }
   static class Static_M
    {
        static void Add()
        {
            Console.WriteLine("Static method Add...");
        }
       static  void Sub()
        {
            Console.WriteLine("Concrete method...");
        }
        public static void Main(String[] args)
        {
            Static_M.Add();
            Static_M.Sub();
           // Static_M m = new Static_M();
           //  Stat.Add();
        }
    }
}
