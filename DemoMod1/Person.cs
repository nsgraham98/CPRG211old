using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod1
{
    public class Person
    {
        string name;
        int id;
        double salary;
        char gender;
        bool isVaccinated;

        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }
        public double Salary { get => salary; set => salary = value; }
        public char Gender { get => gender; set => gender = value; }
        public bool IsVaccinated { get => isVaccinated; set => isVaccinated = value; }

        public Person(string name, int id, double salary, char gender, bool isVaccinated) //parameters called "formal arguments"
        {
            Name = name;
            Id = id;
            Salary = salary;
            Gender = gender;
            IsVaccinated = isVaccinated;
        }
        public Person()
        {

        }
    }
}
