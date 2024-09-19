using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod1
{
    public class Circle
    {
        public const double PI = Math.PI;
        double radius;
        string color;

        public double Radius { get => radius; set => radius = value; }
        public string Color { get => color; set => color = value; }

        //Non parameterized constructor
        //same name as that of class  --- special method
        //intialize the members of a class
        //called automatically at the time of creation of object 
        //ctor + tab --- for non parameterized constructor
        //1st
        public Circle() // Non parameterized constructor
        {
            Radius = 1;
            Color  = "White";
        }

        //formal parameters
        // public Circle(double r, string c)
        //2nd
        public Circle(double radius, string color) // parameterized constructor
        {
            this.radius = radius;  // actual = formal parameter
            //radius = r;
            //color = c;
            this.color = color;
        }

        //3rd
        public Circle(string color, double radius) // parameterized constructor
        {
            this.radius = radius;  // actual = formal parameter
            this.color = color;

        }
        public double CalculateArea() // user defined method
        {
            return PI * Math.Pow(Radius, 2);
        }

        public override string ToString()
        {
            //return base.ToString();
            return $"Circle with a radius: {Radius} and Color: {Color} ";

        }
    }
}
