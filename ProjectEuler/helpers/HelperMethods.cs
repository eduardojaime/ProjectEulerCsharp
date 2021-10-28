using System;
using System.Collections.Generic;

namespace ProjectEuler.Helpers
{
    public static class HelperMethods
    {
        public static void WriteErrorLog(string solution, Exception ex)
        {
            Console.WriteLine($"Error in {solution}: {ex.Message}");
        }
        public static bool IsNumberMultipleOf(int multiple, int number)
        {
            return ((multiple % number) == 0);
        }

        public static bool IsPalindrome(int number)
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

        // Implements trial division as described here: https://khalidabuhakmeh.com/find-prime-numbers-with-csharp-9
        public static bool IsPrime(int number)
        {
            if (number < 1)
                return false;

            double maxPossibleDivisor = Math.Sqrt(number);
            for (double divisor = 2; divisor <= maxPossibleDivisor; divisor++)
            {
                if (number % divisor == 0)
                    return false;
            }
            return true;
        }

    }

}