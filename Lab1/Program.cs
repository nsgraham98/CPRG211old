using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person(1, "Ian", "Brooks", "Red", 30, true);
            Person p2 = new Person(2, "Gina", "James", "Green", 18, false);
            Person p3 = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            Person p4 = new Person(4, "Mary", "Beals", "Yellow", 28, true);

            Person.DisplayPersonInfo(p3);
            Person.ChangeFavoriteColor(p1, "White");
            Person.DisplayPersonInfo(p1);
            Person.GetAgeInTenYears(p4);

            Relation r1 = new Relation("s");
            Relation r2 = new Relation("b");





            Console.ReadLine();
        }
    }
}
