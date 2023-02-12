using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The first 100 prime numbers:");

            int count = 0;
            int number = 2;

            while (count < 100)
            {
                if (IsPrime(number))
                {
                    Console.WriteLine(number);

                    count++;
                }
                number++;
            }

            Console.ReadLine();
        }

        static bool IsPrime(int n)
        {
            if (n <= 1) return false;
            if (n <= 3) return true;
            if (n % 2 == 0 || n % 3 == 0) return false;
            int i = 5;
            while (i * i <= n)
            {
                if (n % i == 0 || n % (i + 2) == 0) return false;
                i += 6;
            }
            return true;
        }
    }
}
