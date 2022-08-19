using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Collections
{
    class InvalidException : ApplicationException
    {
    }
    class Emp1
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
        class Emp
        {
       public Emp(String Name, int Exp)
        { 
        
        }
            static void Main(string[] args)
            {
                Emp1 e = new Emp1();
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

