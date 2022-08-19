using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Collections
{
  
    class ss<T>
    {
        private T obj;
        public T Obj{ get => Obj;set=>Obj = value; }
    }
    class s
    {
        private object obj;
        public object Obj { get => obj; set => obj = value; }
    }
    class Non_Generic_Demo
    {
            static void Main(string[] args)
            {

                ss <float> s1 = new ss<float>();
                s1.Obj = 4.5f;
                float d = s1.Obj;

                s n = new s();
                n.Obj = "OM";
                n.Obj = 9000;

            }
                
    }
}
