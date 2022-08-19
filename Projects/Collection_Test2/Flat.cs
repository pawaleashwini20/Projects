using System;
using System.Collections.Generic;
using System.Text;
//9.	Create a class Flat (flatno,WingName,List<Member> memberlist)
//Member(memberid, membername, profession, age)
//Create of 2 flat objects 


namespace Projects.Collection_Test2
{
    public class Flat1
    {
        public List<member> mlist;
        public string f_wing1;
        //private List<member> ml;

       /* public Flat1(int f_no, string f_wing, List<member> m1)
        { 
        
        }*/

        public Flat1(int f_no, string f_wing1, List<member> mlist)
        {
            this.f_no = f_no;
            this.f_wing1 = f_wing1;
            this.mlist = mlist;
        }

        // public Flat2(int f_no1,String f_no1, List<member> m2)
        //{
        //}

        public int f_no { get; set; }
        public string f_wing { get; set; }
       
       public override string ToString()
        {
            return (f_no + ":" + f_wing);
        }

    }
   public class member
    {
        public member(int id, string m_name, String m_prof, int age)
        {

        }
        public int m_id { get; set; }
        public string m_name { get; set; }
        public String m_prof { get; set; }
        public int m_age { get; set; }
        static void Main(string[] args)
        {   
       
       /* List<member> ll = new List<member>();
        ll.Add(new member(1, "Ashu", "IT", 28));
            ll.Add(new member(2, "Swara", "CS", 33));
       */
    }
        public override string ToString()
        {
            return m_id + ":" + m_name+":"+m_prof+":"+m_age;
        }

    }
    public class Flat
    {
        static void Main(string[] args)
        {
            List<Flat1> fl = new List<Flat1>();
            fl.Add(new Flat1(101, "A", new List<member>()));
           fl.Add(new Flat1(101, "A", new List<member>()));
            
            do
            {
                Console.WriteLine("Enter flatno and wing:");
                int f_no = int.Parse(Console.ReadLine());
                String f_wing = Console.ReadLine();
                Console.WriteLine("How Many Member in flat:");
                int n = int.Parse(Console.ReadLine());
                List<member> mlist = new List<member>();
                for (int i = 1; i <=n; i++)
                {
                    Console.WriteLine("Enter Member name,Proffession,age");
                    String m_name = Console.ReadLine();
                    String m_prof = Console.ReadLine();
                    int m_age = int.Parse(Console.ReadLine());
                    member obj = new member(i, m_name, m_prof, m_age);
                   // obj.Add(new member(i, m_name, m_prof, m_age));
                    mlist.Add(obj);
                }
                fl.Add(new Flat1(f_no, f_wing, mlist));
                Console.WriteLine("u want to continue...");
                String ch = Console.ReadLine();
                if (ch.ToLower() == "no")

                    break;
            } while (true);

            foreach (Flat1 fobj in fl)
            {
                Console.WriteLine("Flat no:"+fobj.f_no);
                Console.WriteLine("Wing:"+fobj.f_wing);
                List<member> mlst = fobj.mlist;
                foreach (member mobj in mlst)
                {
                    Console.WriteLine(mobj);
                }

            }
        }

    }
}
