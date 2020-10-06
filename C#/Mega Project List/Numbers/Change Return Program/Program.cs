using System;
using System.Security.Cryptography.X509Certificates;

namespace Change_Return_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] amounts = { 0, 0, 0, 0, 0 };
            double[] values = { 1, 0.25, 0.1, 0.05, 0.01 };

            double val;
            double cost;

            Console.WriteLine("Enter cost");
            cost = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter payment");
            val = Convert.ToDouble(Console.ReadLine()) - cost;

            for (int x = 0; amounts.Length <= x; x++)
            {
                while (val % values[x] == 0 && val != 0)
                {
                    val -= values[x];
                    amounts[x] += values[x];
                }
            }
            
            foreach (int i in amounts)
            {
                Console.WriteLine("Amounts: " + i.ToString());
                Console.WriteLine("Val: " + val);
            }
        }
    }
}