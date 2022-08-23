using System;
namespace Exercises
{
    public class Person
    {
        //constructor for Person
        public Person(string firstName, string lastName, string city, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.City = city;
            this.Age = age;
        }

        //define properties
        public string FirstName{ get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public int Age { get; set; }
    }

    public class Exercise002
    {
        public bool IsFromManchester(Person person)
        {
            //if person is an object with City equals "Manchester"
            if ( !(person == null) && person.City.Equals("Manchester") )
                return true;
            else
                return false;
        }

        public bool CanWatchFilm(Person person, int ageLimit)
        {
            if (!(person == null) && (person.Age >= ageLimit))
                return true;
            else
                return false;
        }
    }
}
