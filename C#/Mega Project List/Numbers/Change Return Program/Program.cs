using System;
using System.Security.Cryptography.X509Certificates;

namespace Change_Return_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] amounts = {0m, 0m, 0m, 0m, 0m };
            decimal[] values = {1m, 0.25m, 0.1m, 0.05m, 0.01m };

            decimal val;
            decimal cost;
            decimal change;

            Console.WriteLine("Enter cost");
            cost = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter payment");
            val = Convert.ToDecimal(Console.ReadLine());

            change = val - cost;

            foreach(int i in values)
            {
                while (change >= values[i])
                {
                    amounts[i] = Math.Truncate((change / values[i]));
                    change %= values[i];
                    Console.WriteLine(amounts[i]);
                }
            }
        }
    }
}