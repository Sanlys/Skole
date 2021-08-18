using System;
using System.Threading;

namespace Collatz_Conjecture
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Collatz Conjecture");
            Console.WriteLine("Write a number larger than 1");

            int n = Convert.ToInt32(Console.ReadLine());
            int count = 1;
            while (n != 1)
            {
                if (n % 2 == 0) { n /= 2; count++; /*Console.WriteLine(n);*/ } else { n *= 3 + 1; count++; /*Console.WriteLine(n);*/ }
            }
            Console.WriteLine(n);
            Console.WriteLine("It took " + count + " steps");
        }
    }
}
