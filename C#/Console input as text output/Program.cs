using System;
using System.IO;

namespace Console_input_as_text_output
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Console.WriteLine("Enter something to save as a .txt file");
            input = Console.ReadLine();

            File.WriteAllText("Text Document.txt", input);
        }
    }
}
