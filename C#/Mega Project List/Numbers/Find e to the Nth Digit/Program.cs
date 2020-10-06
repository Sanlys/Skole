using System;
using System.Security.Cryptography.X509Certificates;

namespace Find_e_to_the_Nth_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            string E = Convert.ToString(Math.E);
            Console.WriteLine("Enter amount of digits");
            int digits = Convert.ToInt32(Console.ReadLine());
            E = E.Substring(0, digits+1);
            Console.WriteLine(E);
        }
    }
}