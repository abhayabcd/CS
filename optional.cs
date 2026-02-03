using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter multiple lines of text. Press Enter on a blank line to finish:");

        StringBuilder inputBuilder = new StringBuilder();
        string line;

        while (!string.IsNullOrEmpty(line = Console.ReadLine()))
        {
            inputBuilder.AppendLine(line);
        }

        string fullInput = inputBuilder.ToString();
        Console.WriteLine("\n--- Captured Input ---");
        Console.WriteLine(fullInput);
    }
}
