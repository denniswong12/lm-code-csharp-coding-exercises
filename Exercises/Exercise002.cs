using System;
namespace Exercises
{
    public class Exercise002
    {
        public bool IsFromManchester(Person person)
        {
            //return true if person is not null and person.City equals to "Manchester".
            return !(person == null) && person.City.Equals("Manchester");
        }

        public bool CanWatchFilm(Person person, int ageLimit)
        {
            return !(person == null) && (person.Age >= ageLimit);
        }
    }
}
