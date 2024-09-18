using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Person
    {
        int personId;
        string firstName;
        string lastName;
        string favoriteColor;
        int age;
        bool isWorking;

        public int PersonId { get => personId; set => personId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string FavoriteColor { get => favoriteColor; set => favoriteColor = value; }
        public int Age { get => age; set => age = value; }
        public bool IsWorking { get => isWorking; set => isWorking = value; }

        //parameterized constructor
        public Person(int personId, string firstName, string lastName, string favoriteColor, int age, bool isWorking)
        {
            PersonId = personId;
            FirstName = firstName;
            LastName = lastName;
            FavoriteColor = favoriteColor;
            Age = age;
            IsWorking = isWorking;     
        }

        public static void DisplayPersonInfo(Person p)
        {
            Console.WriteLine($"{p.FirstName} {p.LastName}'s info:\nID: {p.PersonId}\nFavorite Color: {p.FavoriteColor}\nAge: {p.Age}\nIs Working: {p.IsWorking}");
        }

        public static string ChangeFavoriteColor(Person p, string newColor)
        {
            p.FavoriteColor = newColor;
            return p.FavoriteColor;
        }

        public static void GetAgeInTenYears(Person p)
        {
            Console.WriteLine($"{p.FirstName} {p.LastName}'s age in 10 years: {p.Age +10}");
        }

        public override string ToString()
        {
            return $"First Name: {FirstName}\nLast Name: {LastName}\nID: {PersonId}\nFavorite Color: {FavoriteColor}\nAge: {Age}\nIs Working: {IsWorking}";
        }
    }
}
