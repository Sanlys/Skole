using System;

namespace Prime_Factorization
{
    class Program
    {

        public static void factorization(int x)
        {
            int y = 2;
            while (y < 10)
            {
                if (x % y == 0)
                {
                    Console.Write(y + " * ");
                    x /= y;
                }
                y++;
            }
        }

        static void Main(string[] args)
        {
            int value = Convert.ToInt32(Console.ReadLine());
            factorization(value);
        }
    }
}