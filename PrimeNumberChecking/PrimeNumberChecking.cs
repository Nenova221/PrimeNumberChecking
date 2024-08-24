using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberChecking
{
    public class PrimeNumberChecking
    {
        public static bool IsPrimeNumber(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
    public class PrimeNumberChecker
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number between 1 and 100: ");
            int n = int.Parse(Console.ReadLine());

            bool isPrime = PrimeNumberChecking.IsPrimeNumber(n);

            if (isPrime)
            {
                Console.WriteLine($"{n} is a prime number.");
            }
            else
            {
                Console.WriteLine($"{n} is not a prime number.");
            }
        }
    }
}

