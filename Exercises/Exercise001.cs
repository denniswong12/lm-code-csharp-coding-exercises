using System;
using System.Collections.Generic;
using Exercises.Models;
using static System.Net.Mime.MediaTypeNames;

namespace Exercises
{
    public class Exercise001
    {
        public string CapitalizeWord(string word)
        {
            string result;

            if (string.IsNullOrEmpty(word)) //check if word is null or empty 
                result = word;
            else
            {
                //Capitalize first letter of the word
                result = $"{word.Substring(0, 1).ToUpper()}{word.Substring(1)}";
            }
            return result;
        }

        public string GenerateInitials(string firstName, string lastName)
        {
            string result;

            if ( string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) )
                result = "First name and Last name must not be empty";
            else
                result = $"{firstName.Substring(0,1).ToUpper()}.{lastName.Substring(0,1).ToUpper()}";

            return result;
        }

        public double AddVat(double originalPrice, double vatRate)
        {
            //if originalPrice or vatRate <0, throw execption with same error message specified in Exercise001Test.cs
            if ( originalPrice < 0 )
            {
                
                throw new ArgumentException($"Price cannot be negative. Please enter a valid price.");
            } else if ( vatRate < 0 ) {
                throw new ArgumentException($"VAT cannot be negative. Please enter a valid VAT.");
            }

            return originalPrice + Math.Round(originalPrice * vatRate / 100, 2);
        }

        public string Reverse(string sentence)
        {
            string result;

            if (string.IsNullOrEmpty(sentence))
                result = sentence;
            else
            {
                //put sentence into a char[] in order to reverse it.
                char[] arr = sentence.ToCharArray();
                Array.Reverse(arr);
                result = new string(arr);
            }
            return result;
        }

        public int CountLinuxUsers(List<User> users)
        {
            int result = 0;

            if (users == null || users.Count == 0)
                result = 0;
            else
            {
                foreach(User u in users)
                {
                    if (u.Type.Equals("Linux"))
                        result++;
                }
            }
            return result;
        }
    }
}
