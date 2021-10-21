using System;
using System.Linq;
using System.Collections.Generic;

namespace ProjectEuler.Solutions {
    public static class Problems001to010
    {
        /// <summary>
        /// Problem 001
        /// Multiples of 3 and 5
        /// Url: https://projecteuler.net/problem=1
        /// </summary>
        public static void Solution001(int limit, bool showOutput)      
        {
            List<int> multiples = new List<int>();

            for (int i = 3; i < limit; i++)
            {
                if (IsNumberMultipleOf(i, 3) || IsNumberMultipleOf(i, 5))
                    multiples.Add(i);
            }

            if (showOutput)
            {
                foreach (int elem in multiples)
                    Console.Write(elem.ToString() + " ");
                Console.Write(Environment.NewLine);
            }

            Console.WriteLine(multiples.Sum()); // Sum from Linq
        }

        #region Helper Methods
        private static bool IsNumberMultipleOf(int multiple, int number)
        {
            return ((multiple % number) == 0);
        }

        private static bool IsPalindrome(int number)
        {
            // 1) Convert number to string and then to char array
            string numText = number.ToString();
            char[] tempArr = numText.ToCharArray();
            // 2) Use Array class to reverse the char array
            Array.Reverse(tempArr);
            // 3) Convert char array to string
            string reversedStr = new string(tempArr);
            // 4) Compare strings, if equal then this is a palindrome
            if (reversedStr == numText)
                return true;
            else
                return false;
            // alternative return line
            // return (reversedStr == numText);
        }
        #endregion 
    }
}