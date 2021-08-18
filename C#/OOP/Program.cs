using System;
using System.Runtime.CompilerServices;

namespace OOP
{
    class Program
    {
        public class X
        {   
            public string x;
            public int y;
            public bool z;
        }
        static void Main(string[] args)
        {
            X a = new X();
            a.x = "String";
            a.y = 50;
            a.z = true;
            Console.WriteLine(a.x);
            Console.WriteLine(a.y);
            Console.WriteLine(a.z);
        }
    }
}
