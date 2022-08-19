using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    interface Int1
    {
        public void Add();
    }
    interface Int2
    {
        public void Add();
        public void Sub();
        public void hiii()
        {
            Console.WriteLine("hellooo....");
        }
    }
    interface Int3
    {
        public void Add();
    }
    class Int_Add : Int1, Int2, Int3
    {
         void Int1.Add()
        {
            Console.WriteLine("Interface1 abstract Method.....");
        }
        void Int2.Add()
        {
            Console.WriteLine("Interface2 abstract Method.....");
        }
         void Int3.Add()
        {
            Console.WriteLine("Interface3 abstract Method.....");
        }
        public void Sub()
        {
            Console.WriteLine("Substraction Abstract Method...");
        }
    }
    class Interface_same_nameM
    {
        static void Main(string[] args)
        {
            Int_Add i = new Int_Add();
            Int1 i1 = new Int_Add();
            i1.Add();
            Int2 i2 = new Int_Add();
            i2.Add();
            Int3 i3 = new Int_Add();
            i3.Add();
           // i2.hii();//we cannot add concrete method in interface
          //  i.Add();
            i.Sub();
        }
    }
}
