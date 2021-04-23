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

        public static void Solution003()
        { }
        public static void Solution004()
        { }
        public static void Solution005()
        { }
        public static void Solution006()
        { }
        public static void Solution007()
        { }
        public static void Solution008()
        { }
        public static void Solution009()
        { }
        public static void Solution010()
        { }

        #region Helper Methods
        private static bool IsNumberMultipleOf(int multiple, int number)
        {
            return ((multiple % number) == 0);
        }
        #endregion
    }
}
