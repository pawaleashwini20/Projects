using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Encapsulation
{
    class Mydata
    {
        private int id;
        private String c_name;
        private int price;
        private String city;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public String C_Name
        {
            get;
            set;
        }
        public int Price
        {
            get { return price; }
            set { price = value; }

        }
        public String City
        {
            get;
            set;
        }
    }
    class Mydate
    {
        private int dd;
        private int mm;
        private int yy;
        
        public int Dd
        {
            get { return dd; }
            set { dd = value; }

        }
        public int Mm
        {
            get { return mm; }
            set { mm = value; }
        }
        public int Yy
        {
            get { return yy; }
            set { yy = value; }
        }
    }
    class Shipment
    {
        private int id;
        Mydata md;
        Mydate md_date;
        static void Main(string[] args)
        {
            Shipment s = new Shipment();
            s.id = 101;

            s.md = new Mydata();
            s.md.Id= 22;
            s.md.C_Name = "Ashwini";
            s.md.Price = 5000;
            s.md.City = "Pune";

            s.md_date = new Mydate();
            s.md_date.Dd = 07;
            s.md_date.Mm = 06;
            s.md_date.Yy = 2022;
            Console.WriteLine("Ship id: "+s.id+" My_data id: "+s.md.Id+" Customer name:"+s.md.C_Name+" Price: "+ s.md.Price+" city: "+s.md.City);
            Console.WriteLine("Date:"+s.md_date.Dd+"/"+s.md_date.Mm+"/"+s.md_date.Yy);
        }
    }
}
