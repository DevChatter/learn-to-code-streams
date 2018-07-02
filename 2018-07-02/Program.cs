using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace _2018_07_02
{
    class Program
    {
        static List<int> primes = new List<int>();

        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            Console.WriteLine("We are finding primes. How high should we go?");
            int.TryParse(Console.ReadLine(), out int maxNumber);
            sw.Start();
            primes.Add(2);
            for (int potentialPrime = 3; potentialPrime < maxNumber; potentialPrime += 2)
            {
                bool itIsPrime = IsPrime(potentialPrime);
                if (itIsPrime)
                {
                    primes.Add(potentialPrime);
                }
            }

            string output = string.Join(", ", primes);
            Console.WriteLine(output);
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
        }

        private static bool IsPrime(int potentialPrime)
        {
            int maxDivisor = (int)Math.Sqrt(potentialPrime);
            foreach (int prime in primes)
            {
                if (potentialPrime % prime == 0)
                {
                    return false;
                }
                if (prime >= maxDivisor)
                {
                    break;
                }
            }
            return true;
        }
    }
}
