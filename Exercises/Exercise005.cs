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
                bool[] marker = new bool[26];
                int ch = 0;
                string lowerInput = input.ToLower();

                for (int i = 0; i < input.Length; i++)
                {
                    if ('a' <= lowerInput[i] && lowerInput[i] <= 'z')
                        ch = lowerInput[i] - 'a';
                    else
                        continue;

                    //mark the existence of a letter of the alphabet
                    marker[ch] = true;
                }

                for (int i = 0; i <= 25; i++)
                {
                    //return false if any one of the 26 letters doesn't exist
                    if (marker[i] == false)
                        return (false);
                }

                return true;
            }
        }
    }
}
