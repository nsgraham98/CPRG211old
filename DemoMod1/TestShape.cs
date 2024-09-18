using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod1
{
    public class TestShape
    {
        public static void Main(string[] args)
        {
            Circle c1 = new Circle();
            //c1.Circle(); // 
            Console.WriteLine("Circle 1 details:");
            Console.WriteLine(c1);
            Console.WriteLine($"Number of circles: {Circle.numberOfCircles}"); //use Circle. instead of c1. because static variable needs to be referenced by class (not by object)

            Circle c2 = new Circle(5, "red");
            Console.WriteLine("\nCircle 2 details:");
            Console.WriteLine(c2);
            Console.WriteLine($"Number of circles: {Circle.numberOfCircles}");


            Rectangle rectangle = new Rectangle();
            Console.WriteLine(rectangle);




            Console.ReadLine();
        }
    }
}
