using System;

namespace Next_Prime_Number
{
    class Program
    {
        public static bool isPrimeNumber(int x)
        {
            int y = 2;
            bool decision = true;
            while (y < 10)
            {
                if (x % y == 0 && !(x == y))
                {
                    decision = false;
                    return false;
                }
                y++;
            }
            return decision;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input next for the next prime number");
            int number = 2;
            string input = Console.ReadLine();
            input = input.ToLower();
            while (input == "next")
            {
                while(!isPrimeNumber(number))
                {
                    number++;
                }
                Console.WriteLine(number);
                number++;
                input = Console.ReadLine();
                input = input.ToLower();
            }
        }
    }
}