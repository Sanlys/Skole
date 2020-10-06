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
                Console.WriteLine("4. Get information about the file");
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
                        Console.WriteLine("Enter directory of text file");
                        string directory = Console.ReadLine();
                        string text = File.ReadAllText(directory);
                        Console.WriteLine("");
                        Console.WriteLine(text);
                        Console.WriteLine("");
                        Console.Write("Enter something to append to the text document: ");
                        input = Console.ReadLine();
                        File.AppendAllText(directory, input);
                        break;
                    case 3:
                        Console.WriteLine("Enter directory of text file");
                        directory = Console.ReadLine();
                        text = File.ReadAllText(directory);
                        Console.WriteLine();
                        Console.WriteLine(text);
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine("Enter directory of text file");
                        directory = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("File attributes: " + File.GetAttributes(directory));
                        Console.WriteLine("File creation time: " + File.GetCreationTime(directory));
                        Console.WriteLine("File creation time (UTC): " + File.GetCreationTimeUtc(directory));
                        Console.WriteLine("File last access time: " + File.GetLastAccessTime(directory));
                        Console.WriteLine("File last access time (UTC): " + File.GetLastAccessTimeUtc(directory));
                        Console.WriteLine("File last write time: " + File.GetLastWriteTime(directory));
                        Console.WriteLine("File last write time (UTC): " + File.GetLastWriteTimeUtc(directory));
                        Console.WriteLine();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}