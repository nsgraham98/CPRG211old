using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod1
{
    public class Rectangle
    {
        double width;
        double length;

        // if no default constructor is set, created object will have default values for its attributes
        // default int -> 0, bool -> False, double -> 0.0, string -> "", char -> "u\0000"

        public Rectangle() //default constructor - non parameterized
        {
            this.length = 0;
            this.width = 0;
        }
        public Rectangle(double w, double l) //parameterized constructor
        {
            this.Width = w;
            this.Length = l;
        }

        public double Width { get => width; set => width = value; }
        public double Length { get => length; set => length = value; }

        // CalculateArea() has same name as method in Circle class -> is called overriding
        public double CalculateArea() //user defined method
        {
            return this.Length * this.Width;
        }

        public override string ToString()
        {
            //return base.ToString();
            return $"Rectangle dimensions are: {Width}, {Length} with area of {(this.length*this.width)}";
        }
    }
}
