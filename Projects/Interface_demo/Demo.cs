using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Interface_demo
{
    interface I1
    {
        void show();

    }
    interface I2
    {
       void show();
    }
   public class Addition : I1, I2
    {
        
       void I1.show()//become private
        {
           // throw new NotImplementedException(); 
            Console.WriteLine("I1...");
        }
         void I2.show()
        {

            Console.WriteLine("I2...");
        }
    }
    class Demo
    {
        static void Main(string[] args)
        {
            Addition a = new Addition();
            I1 i1 = a;
            I2 i2 = a;
            //I1 i1=new Addition();  also create this one
            i1.show();
            i2.show();
        }
    }
}
