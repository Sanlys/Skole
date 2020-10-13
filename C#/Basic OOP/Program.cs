using System;

namespace Basic_OOP
{
    class Program
    {
        static void Main()
        {
            Class1 myClass = new Class1();
            myClass.x = "Test ";
            Class1 mySecondClass = new Class1();
            mySecondClass.x = "Test 2";
            Console.WriteLine(myClass.x + mySecondClass.x);
        }
    }
}
