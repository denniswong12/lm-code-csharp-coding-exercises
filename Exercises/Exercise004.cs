using System;
namespace Exercises
{
    public class Exercise004
    {
        public static DateTime AddGigaSecond(DateTime dateTime)
        {
            //add giga-second to the dateTime and return it.
            return dateTime.AddSeconds(1E9);
        }
    }
}
