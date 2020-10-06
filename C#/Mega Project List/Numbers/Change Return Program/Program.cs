using System;
using System.Security.Cryptography.X509Certificates;

namespace Change_Return_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] amounts = { 0m, 0m, 0m, 0m, 0m };
            decimal[] values = { 1m, 0.25m, 0.1m, 0.05m, 0.01m };

            decimal val;
            decimal cost;
            decimal change;

            Console.WriteLine("Enter cost");
            cost = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter payment");
            val = Convert.ToDecimal(Console.ReadLine());

            
            
            foreach (int i in amounts)
            {
                Console.WriteLine("Amounts: " + i.ToString());
                Console.WriteLine("Val: " + val);
                Console.WriteLine("Change: " + change);
            }
        }
    }
}