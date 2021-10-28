﻿using System;
using ProjectEuler.Solutions;

namespace ProjectEuler
{
    class Program
    {
        const string veryLongNumber = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";

        static void Main(string[] args)
        {
            Console.WriteLine("Hello Project Euler!");
            // Apr 22, 2021 
            // Problems001to010.Solution001(1000, false); // In: 1000 Out: 233168
            // // Oct 25, 2021
            // Problems001to010.Solution002(4000000, false); // In: 4,000,000 Out: 4613732
            // Problems001to010.Solution005(20, false); // In: 20 Out: 232792560
            // // Oct 26, 2021
            // Problems001to010.Solution006(100, false, false); // In: 100 Out: 25164150
            // Problems001to010.Solution007(10001, false, true); // In: 10,001 Out: 104743
            Problems001to010.Solution008(veryLongNumber, 13, true); // In: 13 Out: 23514624000 or 2.3514624E+10
        }
    }
}
