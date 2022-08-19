using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Collections
{
    class Custom_Exce
    {
        class InvalidException : ApplicationException
        {
        }

        class Emp : Object
        {
            String nm;
            int experience;
            public String Nm
            {
                set { this.nm = value; }
                get { return nm; }
            }
            /* public override string ToString()
             {
                 return "name+" + nm + "Experience:"+experience;
             }*/
            public int Experience
            {
                set
                {
                    if (value < 0)
                    {
                        throw new InvalidException();
                    }
                    else
                    {
                        this.experience = value;
                    }
                }
                get { return experience; }

            }
        }
        class Custom_Exp
        {
            static void Main(string[] args)
            {
                Emp e = new Emp();
                Console.WriteLine("Emter name and Experience:");
                e.Nm = Console.ReadLine();
                try
                {
                    e.Experience = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Experience cant be negative..");
                }
                // Console.WriteLine(e);
                Console.WriteLine(" name:" + e.Nm + " Experience:" + e.Experience);
            }
        }
    }

}