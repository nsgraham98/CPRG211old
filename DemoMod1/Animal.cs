
//Object class is the parent of ALL C# classes (aka base, aka superclass)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod1
{
    public class Animal //template class declaration
    {
        //data fields/instance variables/attributes
        //string name; // private by default
        int age;
        string species;

        //highlight name, age, species above -> right click -> quick actions + refactoring -> encapsulate fields and use properties
        //properties access / modify --- getter/setter --- accessor/mutator --- retriever/update
        //public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Species { get => species; set => species = value; }


        //prop + tab -> shortcut for below
        //public string Name { get; set; }

        //use below notation when you need to validate (can use if statement)
        //propfull + tab -> shortcut below
        private string name; // private datafield
        public string Name //public property
        {
            get // getter aka accessor aka retriever
            {
                return name;
            }
            set // setter aka mutator aka updator
            {
                if (value != null)
                {
                    name = value;
                }
                else
                {
                    throw new Exception("Name cannot be null");
                }

            }
        }

        public void Eat() //method ---- defines overall operation/functionality of a class
        {
            Console.WriteLine("Eating....");
        }

        // ctrl + . -> generate overrides -> select ToString()
        public override string ToString() // return the string representation of an object
        {
            //return base.ToString();
            return $"{Name} is a {Species} who is {Age} years old.";
        }
    }
}
