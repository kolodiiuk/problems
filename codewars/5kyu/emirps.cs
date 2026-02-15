using System.Collections.Generic;
using System.Linq;
using System;

public class Emirps
{
    public static long[] FindEmirp(long n)
    {
        if (n < 13)
        {
            return new long[] { 0, 0, 0 };
        }

        long largest = 0;
        long emirpCount = 0;
        long emirpSum = 0;

        var primeSet = new HashSet<long>();
        int digitCount = GetDigitsCount(n);
        var pow = (long)Math.Pow(10, digitCount);
        var numberOfPrimes = pow > n ? pow : n;
        long[] primes = GenPrimes(numberOfPrimes, ref primeSet);
        var list = new List<long>();

        for (int i = 0; i < primes.Length && primes[i] <= n; i++)
        {
            if (IsEmirp(primes[i], in primeSet))
            {
                list.Add(primes[i]);
                largest = primes[i];
                emirpCount++;
                emirpSum += primes[i];
            }
        }

        return new long[] {emirpCount, largest, emirpSum};

        long[] GenPrimes(long num, ref HashSet<long> set)
        {
            if (num < 2)
                return Array.Empty<long>();

            bool[] isPrime = new bool[num];
            Array.Fill(isPrime, true);

            isPrime[0] = isPrime[1] = false;

            for (long i = 4; i < num; i += 2)
            {
                isPrime[i] = false;
            }

            long root = (long)Math.Sqrt(num);
            for (long i = 3; i <= root; i += 2)
            {
                if (isPrime[i])
                {
                    for (long j = i * i; j < num; j += 2 * i)
                    {
                        isPrime[j] = false;
                    }
                }
            }

            for (long i = 2; i < num; i++)
            {
                if (isPrime[i])
                {
                    set.Add(i);
                }
            }

            return set.ToArray();
        }

        bool IsEmirp(long prime, in HashSet<long> set)
        {
            if (prime < 13)
                return false;
            long reversed = 0;

            long t = prime;
            while (t > 0)
            {
                var remainder = t % 10;
                reversed *= 10;
                reversed += remainder;
                t /= 10;
            }

            if (prime > n)
                return false;

            if (reversed == prime)
                return false;

            return set.Contains(reversed);
        }

        int GetDigitsCount(long num)
        {
            long t = num;
            int count = 0;
            while (t > 0)
            {
                t /= 10;
                ++count;
            }

            return count;
        }
    }
}
