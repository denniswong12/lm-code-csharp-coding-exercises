using NUnit.Framework;
using FluentAssertions;
using System;
using NUnit.Framework.Constraints;

namespace Exercises.Tests
{
    public class Exercise004Tests
    {
        [Test]
        public void AddGigaSecond_Should_Return_Result_When_Only_Date_Is_Specified()
        {
            DateTime actualResult = Exercise004.AddGigaSecond(new DateTime(2021, 7, 19));
            DateTime expectedResult = new(2053, 3, 27, 1, 46, 40);
            actualResult.Should().Be(expectedResult);
        }

        [Test]
        public void AddGigaSecond_Should_Return_Result_When_DateTime_Is_Specified()
        {
            DateTime actualResult = Exercise004.AddGigaSecond(new DateTime(2021, 3, 4, 23, 22, 0, 0));
            DateTime expectedResult = new(2052, 11, 11, 1, 8, 40);
            actualResult.Should().Be(expectedResult);
        }

        [Test]
        public void AddGigaSecond_Should_Return_Result_When_DateTime_Is_Specified_With_Day_RollOver()
        {
            DateTime actualResult = Exercise004.AddGigaSecond(new DateTime(2021, 1, 24, 23, 59, 59, 0));
            DateTime expectedResult = new(2052, 10, 3, 1, 46, 39);
            actualResult.Should().Be(expectedResult);
        }

        //Start of additional unit test
        [Test]
        public void AddGigaSecond_Should_Return_Result_When_DateTime_Is_In_Min_Value()
        {
            DateTime actualResult = Exercise004.AddGigaSecond(DateTime.MinValue);
            DateTime expectedResult = new(0032, 9, 9, 1, 46, 40);
            actualResult.Should().Be(expectedResult);
        }

        [Test]
        public void AddGigaSecond_Should_Return_Result_With_Future_DateTIme()
        {
            DateTime actualResult = Exercise004.AddGigaSecond(new DateTime(2122, 12, 31, 23, 59, 59, 0));
            DateTime expectedResult = new(2154, 9, 9, 1, 46, 39);
            actualResult.Should().Be(expectedResult);
        }
        //End of additional unit test
    }
}
