using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
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

        /// <summary>
        /// Problem 002
        /// Even Fibonacci numbers
        /// Url: https://projecteuler.net/problem=2
        /// </summary>
        public static void Solution002(ulong limit, bool showOutput)
        {
            List<ulong> series = new List<ulong>();
            ulong first = 1;
            ulong second = 2;
            ulong next = first + second;
            ulong total = 2; // start with 2 (0, 1, 1, 2....)

            while (next < limit)
            {
                if (next % 2 == 0)
                {
                    total += next;
                    series.Add(next);
                }
                first = second;
                second = next;
                next = first + second;
            }

            if (showOutput)
            {
                foreach (int elem in series)
                    Console.Write(elem + " ");
                Console.Write(Environment.NewLine);
            }

            Console.WriteLine(String.Format("Sum of all even fibonnaci elements is {0}", total));
        }

        /// <summary>
        /// Problem 003
        /// Largest prime factor
        /// Url: https://projecteuler.net/problem=3
        /// Solution: Applies factorization to find the largest odd divisor
        /// </summary>
        public static void Solution003(long number, bool showOutput)
        {
            Stack<long> primeFactors = new Stack<long>();

            for (long div = 2; div <= number; div++)
            {
                // skip even numbers after two
                if (div > 2 && div % 2 == 0)
                    continue;

                while (number % div == 0)
                {
                    primeFactors.Push(div);
                    number = number / div;
                }
            }

            if (showOutput)
            {
                while (primeFactors.Count > 0)
                {
                    Console.Write(primeFactors.Pop().ToString() + " ");
                }
            }
        }

        /// <summary>
        /// Problem 004
        /// Largest palindrome product
        /// Url: https://projecteuler.net/problem=4
        /// </summary>
        public static void Solution004(int limit)
        {
            // range of values go from 0 to limit. i.e. for 3-digit numbers, limit is 999
            // initialize variables
            int numA = limit;
            int numB = limit;

            int result = numA * numB;
            int max = 0;

            while (numA >= 1)
            {
                if (IsPalindrome(result))
                {
                    max = Math.Max(result, max);
                }

                numB--;

                if (numB == 0)
                {
                    numB = limit;
                    numA--;
                }

                result = numA * numB;                
            }

            Console.WriteLine(String.Format("Largest palindrome product of two 3-digit numbers is {0}", max.ToString()));
        }

        /// <summary>
        /// Problem 000
        /// TITLE
        /// Url: https://projecteuler.net/problem=N
        /// </summary>
        public static void Solution005()
        { }

        /// <summary>
        /// Problem 000
        /// TITLE
        /// Url: https://projecteuler.net/problem=N
        /// </summary>
        public static void Solution006()
        { }

        /// <summary>
        /// Problem 000
        /// TITLE
        /// Url: https://projecteuler.net/problem=N
        /// </summary>
        public static void Solution007()
        { }

        /// <summary>
        /// Problem 000
        /// TITLE
        /// Url: https://projecteuler.net/problem=N
        /// </summary>
        public static void Solution008()
        { }

        /// <summary>
        /// Problem 000
        /// TITLE
        /// Url: https://projecteuler.net/problem=N
        /// </summary>
        public static void Solution009()
        { }

        /// <summary>
        /// Problem 000
        /// TITLE
        /// Url: https://projecteuler.net/problem=N
        /// </summary>
        public static void Solution010()
        { }

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
