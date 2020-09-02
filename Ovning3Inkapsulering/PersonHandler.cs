using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning3Inkapsulering
{
    public class PersonHandler
    {
        // Kommer peka alltid till samma objekt om man instantierar person här
        // Person person = new Person();

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

        public int GetAge(Person person)
        {
            return person.Age;
        }
        public void SetAge(Person person, int age)
        {
            person.Age = age;

        }

        public string GetFName(Person person)
        {
            return person.FName;
        }

        public void SetFName(Person person, string fName)
        {
            person.FName = fName;
        }

    }
}
