using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Inheritance
{
    class  Vehicle
    {
        public virtual void run()
        {
            Console.WriteLine("Vehicle is Running...");
        }
    }
    class Car : Vehicle
    {
        public override void run()
        {
            Console.WriteLine("car is running..");
        }
    }
    class Truck : Vehicle 
    {
        public override void run()
        {
            Console.WriteLine("Truck is Running...");
        }
    }
    class OverridingDemo
    {
        static void Main(string[] args)
        {
            // parent p=new child();

           Vehicle v = new Vehicle();
            v.run();

            Vehicle c = new Car();
            c.run();

            Vehicle t = new Truck();
            t.run();


        }
    }
}
