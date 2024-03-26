using System;
using System.IO;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;


namespace Lab8CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab#8 ");
            Console.WriteLine("What task do you want?");
            Console.WriteLine("1. Task 1");
            Console.WriteLine("2. Task 2");
            Console.WriteLine("3. Task 3");
            Console.WriteLine("4. Task 4");
            Console.WriteLine("5. Task 5");
            Console.WriteLine("6. Exit");

            int choice;
            bool isValidChoice = false;

            do
            {
                Console.Write("Enter number of task ");
                isValidChoice = int.TryParse(Console.ReadLine(), out choice);

                if (!isValidChoice || choice < 1 || choice > 4)
                {
                    Console.WriteLine("This task not exist");
                    isValidChoice = false;
                }
            } while (!isValidChoice);
            switch (choice)
            {
                case 1:
                    task1();
                    break;
                case 2:
                    task2();
                    break;
                case 3:
                    task3();
                    break;
                case 4:
                    task4();
                    break;
                case 5:
                    task5();
                    break;
                case 6:
                    break;
            }
        }

        static void task1()
        {
            Console.Write("Task 1\n");
            string inputFilePath = "input.txt";
            string text = File.ReadAllText(inputFilePath);

            Regex regex = new Regex(@"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}\b");

            MatchCollection matches = regex.Matches(text);

            string outputFilePath = "output_task1.txt";
            using (StreamWriter writer = new StreamWriter(outputFilePath, false)) // Открываем файл для записи, перезаписывая содержимое
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

        static void task2()
        {
            Console.Write("Task 2\n");
            string inputFilePath = "input.txt";
            string text = File.ReadAllText(inputFilePath);

            text = Regex.Replace(text, @"\b\w\b", "");
            text = Regex.Replace(text, @"\b[a-eA-E]\w*\b", "");

            string outputFilePath = "output_task2.txt";
            if (File.Exists(outputFilePath))
            {
                File.Delete(outputFilePath); 
            }

            File.WriteAllText(outputFilePath, text); 

            Console.WriteLine("Operation completed. Results written to output_task2.txt");
        }

        static string RepChar(string[] words)
        {
            string MostRepChar = string.Empty;
            int maxRepChar = 0;

            foreach (string word in words)
            {
                int count = 0; 
                char firstChar = word[0]; 
                char lastChar = word[word.Length - 1]; 

                if (firstChar == lastChar)
                {
                    foreach (char c in word)
                    {
                        if (c == firstChar)
                        {
                            count++;
                        }
                    }

                    if (count > maxRepChar)
                    {
                        maxRepChar = count;
                        MostRepChar = word;
                    }
                }
            }

            return MostRepChar;
        }

        static void task3()
        {
            Console.Write("Task 3\n");
            string inputFilePath = "input.txt";
            string[] words = File.ReadAllText(inputFilePath).Split(new[] { ' ', ',', '.', ';', ':', '-', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            string MostRepChar = RepChar(words);

            string outputFilePath = "output_task3.txt";
            File.WriteAllText(outputFilePath, MostRepChar);

            Console.WriteLine($"Result has been written to {outputFilePath}");
        }
        static void task4()
        {
            Console.WriteLine("Task 4");
            string inputFilePath = "input.txt";
            string text = File.ReadAllText(inputFilePath);

            // Розділити текст на слова
            string[] separators = { " ", ",", ".", ";", ":", "-", "\n", "\r", "\t" };
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            List<string> matchingWords = new List<string>();

            foreach (string word in words)
            {
                if (word.Length > 1 && word[0] == word[word.Length - 1])
                {
                    matchingWords.Add(word);
                }
            }

            string outputFilePath = "output_task4.txt";
            File.WriteAllLines(outputFilePath, matchingWords);

            Console.WriteLine($"Operation completed. Results written to {outputFilePath}");
        }

        static void task5()
        {
            Console.Write("Task 5");

        }
    }
}
