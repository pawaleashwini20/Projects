using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Encapsulation
{
    class pen
    { 
        private float len;
        private string color;
        private float price;
        public float Len
        {
            get { return len; }
            set { len = value; }
        }
        public string Col
        {
            get; //{ return color; }
            set;//{ color = value; }
        }
        public float Price
        {
            get { return price; }
            set { price = value; }
        }
    }
    class nib
    {
        private string m_type;
        public string M_type
        {
            get;// { return m_type; }
            set;//{ m_type = value; }
        }
    }
    class Bag
    {
        private String brand;
        private string colour;
        pen p;
        nib n;
        public string Brand
        {
            get;
            set;
        }
        public String Colour
            {
            get;
            set;
            }
        static void Main(string[] args)
        {
            Bag b = new Bag();
            b.Brand = "Lenovo";
            b.Colour = "Black";
           
            b.p = new pen();
            b.p.Len =5;
            b.p.Col = "Red";
            b.p.Price = 10;

            b.n = new nib();
            b.n.M_type = "Copper";
            Console.WriteLine("Bag Brand: "+b.Brand+" Bag color:"+b.Colour+" Pen Length: "+b.p.Len+" pen color: "+b.p.Col+" pen price: "+b.p.Price+"  Nib Type:"+b.n.M_type );
        }
    }
}
