using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Methods
{
    class Car
    {
        String C_model;
        String C_name;
        String C_color;
        int C_price;
        public void input(String C_model, String C_name, String C_color, int C_price)
        {
            Console.WriteLine("Model: "+C_model+"\tName: "+C_name+"\tcolor: "+C_color+"\tC_price: "+C_price);
        }
        static void Main(string[] args)
        {
            Car c = new Car();
            c.input("ABC","Innova","Black",120000);
            c.input("PQR", "Creta", "While", 154560);
        }
    }
}
