using System;
namespace Exercises
{
    public class Exercise005
    {
        public bool IsPangram(string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;
            else
            {
                bool[] alphabetList = new bool[26];
                int alphabetPos = -1;
                string lowerCaseInput = input.ToLower();

                for (int i = 0; i < input.Length; i++)
                {
                    if ('a' <= lowerCaseInput[i] && lowerCaseInput[i] <= 'z')
                    {
                        alphabetPos = lowerCaseInput[i] - 'a';

                        //mark the existence of a letter of the alphabet
                        alphabetList[alphabetPos] = true;
                    }
                }

                for (int i = 0; i <= 25; i++)
                {
                    //return false if any one of the 26 letters doesn't exist
                    if (alphabetList[i] == false)
                        return (false);
                }

                return true;
            }
        }
    }
}
