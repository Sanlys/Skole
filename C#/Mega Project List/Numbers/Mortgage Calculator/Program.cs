using System;

namespace Mortgage_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalValue;
            double interest;
            int terms;


            Console.WriteLine("Input total value of mortgage");
            totalValue = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Input interest rate (Without %)");
            interest = Convert.ToDouble(Console.ReadLine());
            interest = totalValue * interest / 100;
            totalValue += interest;

            Console.WriteLine("Input total amount of terms");
            terms = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Amount to pay per term");
            Console.WriteLine(totalValue/terms);

        }
    }
}
