using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Inheritance
{
    class patient
    {
        public virtual void treatment()
        {
            Console.WriteLine("Patient class treadment.....");
        }
        public virtual void medicine()
        {
            Console.WriteLine("Parent class medicine....");
        }
    }
    class nurse:patient
    {
        public override void treatment()
        {
            base.treatment();
            Console.WriteLine("nurse class treatment.....");
        }
        public void worker()
        {
            base.medicine();
            Console.WriteLine("patient class worker....");
        }
    }
    class Doctor:nurse
    {
        static void Main(string[] args)
        {
            nurse n = new nurse();
           // patient p = new nurse();
            //p.treatment();
            n.treatment();
            n.worker();
        }
    }
}
