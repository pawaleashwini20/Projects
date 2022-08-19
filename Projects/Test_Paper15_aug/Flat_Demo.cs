using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//3.	Assume that there is already  list of members of Society Member{memberid,Wing_flatNo,name}.
//Write a program which creates Dictionary
//where key is Wing_FlatNo and value is List of all  names of family members [
namespace Projects.Test_Paper15_aug
{
    class flat
    {
       private int mid, fno;
        String name;
        public flat(int mid, int fno, String name)
        {
            this.mid = mid;
            this.fno = fno;
            this.name = name;

        }
        public int Mid
        {
            set;
            get;
        }
        public int Fno
        {
            set;
            get;
        }
        public int Name
        {
            set;
            get;
        }
        public override string ToString()
        {
            return(mid+" "+fno+" "+name);
        }
    }
    class Flat_Demo
    {
        static void Main(string[] args)
        {
            Dictionary<flat, int> dd = new Dictionary<flat, int>();
            dd.Add(new flat(1, 101, "AAA"), 101);
            dd.Add(new flat(2, 102, "ZZZ"), 102);
            dd.Add(new flat(3, 107, "CCC"), 107);
            dd.Add(new flat(4, 104, "DDD"), 104);
            dd.Add(new flat(5, 109, "WWW"), 109);
            dd.Add(new flat(6, 112, "ABC"), 112);
            dd.Add(new flat(5, 109, "XYZ"), 111);
            foreach (KeyValuePair<flat, int> s in dd)
            {
                Console.WriteLine(s.Key+"===  >"+s.Value);
            }
            Console.WriteLine("///////////////////");
            foreach(KeyValuePair<flat,int> k in dd.OrderBy(Key=>Key.Value))
            {
                Console.WriteLine(k.Key+"==>"+k.Value);
            }
        }
    }
}
