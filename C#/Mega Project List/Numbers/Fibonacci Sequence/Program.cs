using System;

namespace Fibonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            double goldenRatio = (1 + Math.Sqrt(5)) / 2;
            double input = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter n to get nth term of the Fibonacci Sequence");
            double psi = 1 - goldenRatio;
            double goldenRatioPwr = Math.Pow(goldenRatio, input);
            double psiPwr = Math.Pow(psi, input);
            double output = (goldenRatioPwr - psiPwr) / Math.Sqrt(5);
            Console.WriteLine(output);

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}