using System;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Project Euler!");
            Problems001to010.Solution001(1000, false);
            Problems001to010.Solution002(4000000, false);
            Problems001to010.Solution003(600851475143, false); // expected 6857
            Problems001to010.Solution004(999); // expected 906609
        }
    }
}
