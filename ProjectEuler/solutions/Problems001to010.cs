using System;
using System.Linq;
using System.Collections.Generic;
using ProjectEuler.Helpers;

namespace ProjectEuler.Solutions
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
                if (HelperMethods.IsNumberMultipleOf(i, 3) || HelperMethods.IsNumberMultipleOf(i, 5))
                    multiples.Add(i);
            }

            if (showOutput)
            {
                foreach (int elem in multiples)
                    Console.Write(elem.ToString() + " ");
                Console.Write(Environment.NewLine);
            }

            Console.WriteLine($"Solution 001: {multiples.Sum()}"); // Sum from Linq
        }

        /// <summary>
        /// Problem 002 
        /// Even Fibonacci numbers
        /// Url: https://projecteuler.net/problem=2
        /// </summary>
        public static void Solution002(uint limit, bool showOutput)
        {
            try
            {
                uint numberA = 2;
                uint numberB = 3;
                uint sum = 2; // starts with 2

                while (numberB < limit)
                {
                    if (numberB % 2 == 0)
                        sum += numberB;
                    uint temp = numberB;
                    numberB = numberA + numberB;
                    numberA = temp; // old B value
                    if (showOutput)
                        Console.WriteLine($"A: {numberA} B: {numberB} Sum: {sum}");
                }
                Console.WriteLine($"Solution 002: {sum}");
            }
            catch (Exception ex)
            {
                HelperMethods.WriteErrorLog("Solution002", ex);
            }
        }

        /// <summary>
        /// Problem 005
        /// Smallest Multiple
        /// Url: https://projecteuler.net/problem=5
        /// </summary>
        public static void Solution005(int limit, bool showOutput)
        {
            try
            {
                int minNumber = limit;
                bool found = false;
                int divisor = 0;
                // brute force approach
                while (!found)
                {
                    found = true; // assume I'll find it in this round
                    for (int i = 1; i <= limit; i++)
                    {
                        divisor = i;
                        if (minNumber % i > 0)
                        {
                            found = false; // as soon as a number doesn't comply mark as not found and leave
                            if (showOutput)
                                Console.WriteLine($"Number: {minNumber} Divisor: {divisor} Found: {found}");
                            minNumber++;
                            break;
                        }
                    }
                    if (found && showOutput)
                    {
                        Console.WriteLine($"Number: {minNumber} Divisor: {divisor} Found: {found}");
                    }
                }
                Console.WriteLine($"Solution 005: {minNumber.ToString()}");
            }
            catch (Exception ex)
            {
                HelperMethods.WriteErrorLog("Solution003", ex);
            }
        }

        /// <summary>
        /// Problem 006
        /// Sum square difference
        /// Url: https://projecteuler.net/problem=6
        /// </summary>
        public static void Solution006(int limit, bool showOutput, bool useBruteForce)
        {
            try
            {
                double sumSquares = 0; // int is 4 bytes
                double sumNatural = 0; // double is 8 bytes
                double result = 0;

                if (useBruteForce)
                {
                    // brute force approach
                    // casts int to double automatically but needs explicit cast to 
                    // do double to int
                    for (int i = 1; i <= limit; i++)
                    {
                        double sqr = Math.Pow(i, 2); // or i * i
                        sumSquares += sqr;
                        sumNatural += i;
                        if (showOutput)
                            Console.WriteLine($"Nbr: {i.ToString()} Sqr: {sqr.ToString()} sumSquares: {sumSquares.ToString()} sumNatural: {sumNatural.ToString()}");
                    }
                    // Square of the sum - sum of squares
                    result = Math.Pow(sumNatural, 2) - sumSquares;
                    Console.WriteLine($"Solution 006: {result.ToString()}");
                }
                else
                {
                    // formula approach
                    sumNatural = (limit * (limit + 1)) / 2;
                    sumSquares = (((2 * limit) + 1) * (limit + 1) * limit) / 6;
                    result = Math.Pow(sumNatural, 2) - sumSquares;
                    Console.WriteLine($"Solution 006: {result.ToString()}");
                }
            }
            catch (Exception ex)
            {
                HelperMethods.WriteErrorLog("Solution006", ex);
            }
        }

        /// <summary>
        /// Problem 007
        /// Smallest Multiple
        /// Url: https://projecteuler.net/problem=7
        /// </summary>
        public static void Solution007(int limit, bool showOutput, bool useBruteForce)
        {
            try
            {
                Stack<int> primeNbrs = new Stack<int>();

                if (useBruteForce)
                {
                    for (int i = 2; primeNbrs.Count < limit; i++)
                    {
                        bool isPrime = HelperMethods.IsPrime(i);
                        if (isPrime)
                            primeNbrs.Push(i);
                        if (showOutput)
                            Console.WriteLine($"Nbr: {i.ToString()} IsPrime: {isPrime.ToString()}");
                    }
                    Console.WriteLine($"Solution 007: {primeNbrs.Pop().ToString()}");
                }
                else
                {
                    Console.WriteLine("Solution 007: Optimized solution not implemented");
                }
            }
            catch (Exception ex)
            {
                HelperMethods.WriteErrorLog("Solution007", ex);
            }
        }

        /// <summary>
        /// Problem 008
        /// Largest product in a series
        /// Url: https://projecteuler.net/problem=8
        /// </summary>
        public static void Solution008(string longNumber, int adjDigits, bool showOutput)
        {
            // Approach: split the very long string into substrings without any 0s
            // any number times 0 results in 0
            // validate substrings: those that don't contain 0s and have a length greater than the required number of adjacent digits
            // multiply digits in these substring with an sliding window approach until there are no more digits left
            try
            {
                float result = 0;
                var possibleSeries = longNumber.Split("0");

                foreach (var validSeries in possibleSeries)
                {
                    if (validSeries.Count() < adjDigits)
                    {
                        if (showOutput)
                            Console.WriteLine($"String not valid: {validSeries}");
                    }
                    else
                    {
                        if (showOutput)
                            Console.WriteLine($"String valid: {validSeries}");

                        for (int i = 0; i <= validSeries.Count() - adjDigits; i++)
                        {
                            float product = 1;
                            string subStr = validSeries.Substring(i, adjDigits);

                            foreach (var c in subStr)
                            {
                                int val = int.Parse(c.ToString());
                                product *= val;
                            }

                            if (product > result)
                                result = product;

                            if (showOutput)
                                Console.WriteLine($"Substring: {subStr} Product: {product.ToString()} Result: {result.ToString()}");
                        }
                    }
                }
                Console.WriteLine($"Solution 008: {result.ToString()}");
            }
            catch (Exception ex)
            {
                HelperMethods.WriteErrorLog("Solution008", ex);
            }
        }
        /// <summary>
        /// Problem 000
        /// Smalles Multiple
        /// Url: https://projecteuler.net/problem=0
        /// </summary>
        public static void Solution000()
        {
            try
            {
                Console.WriteLine($"Solution 000: 000");
            }
            catch (Exception ex)
            {
                HelperMethods.WriteErrorLog("Solution000", ex);
            }
        }
    }
}