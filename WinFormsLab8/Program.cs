using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string inputFilePath = "input.txt";
        string text = File.ReadAllText(inputFilePath);

        Regex regex = new Regex(@"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}\b");

        MatchCollection matches = regex.Matches(text);

        string outputFilePath = "output.txt";
        using (StreamWriter writer = new StreamWriter(outputFilePath))
        {
            writer.WriteLine("Found email addresses:");

            foreach (Match match in matches)
            {
                writer.WriteLine(match.Value);
            }

            writer.WriteLine($"Total count: {matches.Count}");
        }

        Console.WriteLine("Operation completed. Results written to output.txt");
    }
}
