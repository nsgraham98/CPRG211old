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
        public static int numberOfCircles; //static remembers value in this context (will not be re-initialized every time)

        public double Radius { get => radius; set => radius = value; }
        public string Color { get => color; set => color = value; }

        // Non parameterized constructor
        // Same name as that of class --- special method
        // only used to initialize the members of a class
        // called automatically at the time of creation of object
        // ctor + tab -> non parameterized constructor shortcut
        public Circle() // Non Parameterized contructor
        {
            Radius = 1;
            Color = "white";
            numberOfCircles++; //1
        }

        // formal parameters
        public Circle(double radius, string color) // Parameterized constructor
        {
            this.radius = radius; // actual = formal parameter (similar to self.xyz in python)
            this.color = color;
            numberOfCircles++; //2

        }

        public double CalculateArea() // user defined method
        {
            return PI * Math.Pow(Radius, 2);
        }

        public override string ToString()
        {
            return $"Circle with radius: {Radius} and Color: {Color}";
        }
    }
}
