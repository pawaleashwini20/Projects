using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Array_1D_Test
{
    /*A Pen contains variables Refill, capLength and brand. Refill has variables
inkColor, length and Nib (tip). Nib has variables materialType and width. Create
a  class structure for above. Write a main method which sets values in all the variables
using setter methods and prints all the variables using getter methods. 
*/
    class Pens
    {
        private string refill;
        private int cap_len;
        private string brand;
        public string Refill//(String inl_col, int len, String nib)
        {
            get;
            set;
        }
        public int Cap_Len
        {
            get { return cap_len; }
            set { cap_len = value; }
        }
        public string Brand
        {
            get;//{ return brand; }
            set;// { Brand = value; }
        }

    }
    class Refill
    {
        private string ink_col;
        private int len;
        private string nib;
        public string Ink_col
        {
            get;
            set;
        }
        public int Len
        {
            get { return len; }
            set { len = value; }
        }
        public string Nib
        {
            get;
            set;
        }
    }
    class Nib
    {
        private String m_type;
        private float width;
        public string M_type
        {
            get;
            set;
        }
        public float Width
        {
            get { return width; }
            set { width = value; }
        }
    }
    class Pen
        {
        Pens M;
        Nib n;
        Refill r;
        static void Main(string[] args)
        {
            Pen p = new Pen();
            p.M = new Pens();
            p.M.Refill="Black";
            p.M.Cap_Len = 5;
            p.M.Brand = "Roritto";
            p.r = new Refill();
            p.r.Ink_col = "RED";
            p.r.Len = 10;
            p.r.Nib = "Plastic";
            p.n = new Nib();
            p.n.M_type = "Thin";
            p.n.Width = 2;
            Console.WriteLine(p.M.Refill+"  " + p.M.Cap_Len+ " " + p.M.Brand+" "+ p.r.Ink_col+" " + p.r.Len+" "+p.r.Nib+" " + p.n.M_type+" " +p.n.Width );

        }
        }
}
