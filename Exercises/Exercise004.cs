using System;

namespace Exercises
{
    public class Exercise004
    {
        public static DateTime AddGigaSecond(DateTime dateTime)
        {
            const double gigaSecond = 1E9;

            return dateTime.AddSeconds(gigaSecond);
        }
    }
}
