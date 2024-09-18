using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod1
{
    public class animalTest
    {
        public static void Main(string[] args)
        {
            // creating new Animal object (a1)
            Animal a1 = new Animal(); //object of Animal class that can access instance variables of Animal class
            a1.Name = "Fido"; //setting value 
            a1.Age = 10;
            a1.Species = "Dog";

            //Console.WriteLine($"{a1.Name} is a {a1.Species} who is {a1.Age} years old.");
            Console.WriteLine(a1.ToString());

            Animal a2 = new Animal();
            a2.Name = "Fluffy"; //setting value 
            a2.Age = 5;
            a2.Species = "Cat";

            //Console.WriteLine($"{a2.Name} is a {a2.Species} who is {a2.Age} years old.");
            Console.WriteLine(a2); //will implicitly call .ToString()

            Console.WriteLine("Animal a1 details:");
            a1.Eat();
            Console.WriteLine("Animal a2 details:");
            a2.Eat();





            Console.ReadLine();
        }
    }
}
