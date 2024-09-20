using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class PersonHandler
    {
        // Metod för att sätta ålder via PersonHandler
        public void SetAge(Person pers, int age)
        {
            pers.Age = age; // Använder Person-objektets Age property
        }

        // Metod för att skapa en person med angivna värden
        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            Person person = new Person();
            person.Age = age;
            person.FName = fname;
            person.LName = lname;
            person.Height = height;
            person.Weight = weight;
            return person;
        }

        // Metod för att sätta för- och efternamn
        public void SetNames(Person pers, string fname, string lname)
        {
            pers.FName = fname;
            pers.LName = lname;
        }

        // Metod för att sätta längd och vikt
        public void SetHeightAndWeight(Person pers, double height, double weight)
        {
            pers.Height = height;
            pers.Weight = weight;
        }

        // Metod för att hämta ålder
        public int GetAge(Person pers)
        {
            return pers.Age;
        }

        // Metod för att hämta fullständigt namn
        public string GetFullName(Person pers)
        {
            return $"{pers.FName} {pers.LName}";
        }

        // Metod för att hämta längd och vikt
        public (double, double) GetHeightAndWeight(Person pers)
        {
            return (pers.Height, pers.Weight);
        }
    }
}
