using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projects.LINQ_DEMO
{
    class Emp
    { 
    public int id { set; get; }
        public string name { get; set; }
        public int salary { get; set; }
        public string city { get; set; }
        public override String ToString()
        {
            return $"{ id}=>{name}=>{salary}=>{city}";
        }
    }
    class Employeee
    {
        static void Main(string[] args)
        {
            List<Emp> ll = new List<Emp>
            {
                new Emp{id=101,name="AAA",salary=100000,city="pune" },
                new Emp{id=102,name="ZZZ",salary=67230,city="Mumbai" },
                new Emp{id=103,name="SSS",salary=34500,city="Delhi" },
                new Emp{id=104,name="BBB",salary=15000,city="pune" },
                new Emp{id=105,name="PPP",salary=9990,city="Dubai" },
            };
            var result = from l in ll
                         select l;
           
            var result1 = from l in ll
                          orderby l.name ascending
                          select l;

            var result2 = from l in ll
                          where l.salary > 20000
                          select l;

            var result3 = from l in ll
                          where l.city.Contains("pune")
                          select l;

            var result4=from l in ll
                        where l.salary>20000
                        orderby l.salary ascending
                        select l;
            var result5 = from l in ll
                          where l.salary>25000 &&
                          l.city.Contains("Mumbai")
                          select l;

            var result6=from l in ll
                        where
                        l.name.StartsWith("P")
                        select l;

            foreach (Emp item in result6)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------lambda--------------------");

            var res = ll.OrderBy(e => e.name).ToList();

            var res1=ll.Where(e=>e.salary>25000).ToList();

            var res2 = ll.Where(e => e.city == "pune").ToList();

            var res3 = ll.OrderBy(e => e.salary).ToList();

            var res4 = ll.Where(e => e.city.StartsWith("p")).ToList();

            var res5 = ll.Where(e=>e.salary>25000 && e.city==("Mumbai")).ToList();

            foreach (Emp item in res5)
            {
                Console.WriteLine(item);
            }

        }
    }
}
