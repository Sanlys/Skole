using System;

namespace OOPDifferentFile
{
    class Program
    {
        static void Main(string[] args)
        {
            External_Class a = new External_Class();
            a.x = 10;
            Console.WriteLine(a.x);
        }
    }
}
