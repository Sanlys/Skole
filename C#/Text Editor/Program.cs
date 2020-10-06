using System;
using System.IO;

namespace Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                Console.WriteLine("Pick an option: ");
                Console.WriteLine("1: Write to new file");
                Console.WriteLine("2: Append something to text file");
                Console.WriteLine("3. View text file");
                int decision = Convert.ToInt32(Console.ReadLine());

                switch (decision)
                {
                    case 1:
                        string input;
                        Console.WriteLine("Enter something to save as a .txt file");
                        input = Console.ReadLine();

                        Console.WriteLine("Enter a file name");
                        string name = Console.ReadLine() + ".txt";

                        File.WriteAllText(name, input);
                        break;
                    case 2:
                        string input2;
                        Console.WriteLine("Enter directory of text file");
                        string directory = Console.ReadLine();
                        string text2 = File.ReadAllText(directory);
                        Console.WriteLine("");
                        Console.WriteLine(text2);
                        Console.WriteLine("");
                        Console.Write("Enter something to append to the text document: ");
                        input2 = Console.ReadLine();
                        File.AppendAllText(directory, input2);
                        break;
                    case 3:
                        Console.WriteLine("Enter directory of text file");
                        string directory2 = Console.ReadLine();
                        string text3 = File.ReadAllText(directory2);
                        Console.WriteLine();
                        Console.WriteLine(text3);
                        Console.WriteLine();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}