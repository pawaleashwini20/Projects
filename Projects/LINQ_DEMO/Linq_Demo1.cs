using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projects.LINQ_DEMO
{
    class products
    {
        public int id { set; get; }
        public String name { get; set; }
        public int price { get; set; }
        public String company{get; set;}
        public override string ToString()
        {
            return $"{id}=>{name}=>{price}=>{company}";
        }
    }
    class Linq_Demo1
    {
        static void Main(string[] args)
        {
            List<products> ll = new List<products>
            {
                new products{id=1,name="Keyboard",price=2234,company="Lenovo" },
                new products{id=2,name="Ram",price=10234,company="Intel" },
                new products{id=3,name="Mouse",price=3000,company="Dell" },
                new products{id=4,name="Monitor",price=90000,company="HP" },
                new products{id=5,name="Ram",price=2234,company="Lenovo" },
            };
            //product prod;
            var result = from p in ll
                         select p;

            var result1 = from p in ll
                          where p.price > 2000
                          select p;

            var result2 =from p in ll
                         where p.price > 2000
                         orderby p.price descending
                         select p;

            foreach (products item in result2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
