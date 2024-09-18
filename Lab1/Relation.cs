using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Relation
    {
        public string RelationshipType { get; set; }

        enum Relationship
        {
            Brother,//0
            Sister,//1
            Father,//2
            Mother//3
        }
        public Relation(string x)
        {
            RelationshipType = x;
        }

        public void ShowRelationship(Person p1, Person p2)
        {
            switch(RelationshipType)
            {
                case ("s"):
                    Console.WriteLine($"Relationship between {p1.FirstName} and {p2.FirstName} is: {Relationship.Sister}");
                    break;
                case ("b"):
                    Console.WriteLine($"Relationship between {p1.FirstName} and {p2.FirstName} is: {Relationship.Brother}");
                    break;
                case ("f"): Console.WriteLine($"Relationship between {p1.FirstName} and {p2.FirstName} is: {Relationship.Father}");
                    break;
                case ("m"):
                    Console.WriteLine($"Relationship between {p1.FirstName} and {p2.FirstName} is: {Relationship.Mother}");
                    break;
            }
        }

        
        
        
    }
}
