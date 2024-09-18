using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod1
{
    public class TestPerson
    {
        public static void Main(string[] args)
        {
            Person p1 = new Person();// p1 created using default values
            Console.WriteLine("\nFirst person details: (setup by default constructor) ");
            Console.WriteLine($"Name: {p1.Name}");
            Console.WriteLine($"ID: {p1.Id}");
            Console.WriteLine($"Salary: {p1.Salary}");
            Console.WriteLine($"Gender: {p1.Gender}");
            Console.WriteLine($"IsVaccinated: {p1.IsVaccinated}");

            Person p2 = new Person("Harinder", 123, 50000, 'F', true);
            Console.WriteLine("\nSecond person details:");
            Console.WriteLine($"Name: {p2.Name}");
            Console.WriteLine($"ID: {p2.Id}");
            Console.WriteLine($"Salary: {p2.Salary}");
            Console.WriteLine($"Gender: {p2.Gender}");
            Console.WriteLine($"IsVaccinated: {p2.IsVaccinated}");

            Person p3 = new Person("Nick", 456, 100000, 'M', true);
            Console.WriteLine("\nThird person details:");
            Console.WriteLine($"Name: {p3.Name}");
            Console.WriteLine($"ID: {p3.Id}");
            Console.WriteLine($"Salary: {p3.Salary}");
            Console.WriteLine($"Gender: {p3.Gender}");
            Console.WriteLine($"IsVaccinated: {p3.IsVaccinated}");

            //// local variable with primitive data type (will give error)
            //string name;
            //Console.WriteLine(name);

            int i = 10;
            int j;
            j = i; // primitive data type assignment
            Console.WriteLine(j + " " + i);

            // What happens when you assign one object to another (p2 = p3;)
            Console.WriteLine("\nBefore assignment");
            Console.WriteLine($"Name of 2nd person: {p2.Name}");
            Console.WriteLine($"Name of 3rd person: {p3.Name}");

            p2 = p3; //assignment (objects)
            Console.WriteLine("\nAfter assignment");
            Console.WriteLine($"Name of 2nd person: {p2.Name}");
            Console.WriteLine($"Name of 3rd person: {p3.Name}");

            //pass by reference (p3) and pass by value (i)
            DisplayPersonInfo(p3, i); // (object, simple variable)
            Console.WriteLine(i);

            Person newPerson = ChangePersonInfo(p3);
            Console.WriteLine("\nNew person details:");
            Console.WriteLine($"Name: {newPerson.Name}");
            Console.WriteLine($"ID: {newPerson.Id}");
            Console.WriteLine($"Salary: {newPerson.Salary}");
            Console.WriteLine($"Gender: {newPerson.Gender}");
            Console.WriteLine($"IsVaccinated: {newPerson.IsVaccinated}");


            Console.ReadLine();

        }
        public static void DisplayPersonInfo(Person p, int h)
        {
            // h is local to this block
            h = 5000; //changing h does not change i (i is simple variable being passed)
            Console.WriteLine($"Name: {p.Name}");
            Console.WriteLine($"ID: {p.Id}");
            Console.WriteLine($"Salary: {p.Salary}");
            Console.WriteLine($"Gender: {p.Gender}");
            Console.WriteLine($"IsVaccinated: {p.IsVaccinated}");
            Console.WriteLine($"Value of Primitive datatype: {h}");
        }

        public static Person ChangePersonInfo(Person y)
        {
            y.Name = "John";
            y.Id = 101;
            return y;
        }
    }
}
