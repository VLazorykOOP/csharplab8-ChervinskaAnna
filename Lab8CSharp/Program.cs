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

                if (!isValidChoice || choice < 1 || choice > 7)
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
            Console.WriteLine("Task 4\n");
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

        static void PrintFileInfo(string filePath)
        {
            FileInfo fileInfo = new FileInfo(filePath);
            Console.WriteLine($"File Name: {fileInfo.Name}");
            Console.WriteLine($"Directory: {fileInfo.DirectoryName}");
            Console.WriteLine($"Size (bytes): {fileInfo.Length}");
            Console.WriteLine($"Creation Time: {fileInfo.CreationTime}");
            Console.WriteLine($"Last Access Time: {fileInfo.LastAccessTime}");
            Console.WriteLine($"Last Write Time: {fileInfo.LastWriteTime}");
            Console.WriteLine();
        }

        static void task5()
        {
            string studentName = "Chervinska";

            string folder1Path = $"C:\\temp\\{studentName}1";
            string folder2Path = $"C:\\temp\\{studentName}2";

            Directory.CreateDirectory(folder1Path);
            Directory.CreateDirectory(folder2Path);

            // Task2
            string t1FilePath = Path.Combine(folder1Path, "t1.txt");
            string t2FilePath = Path.Combine(folder1Path, "t2.txt");

            string t1Text = "Шевченко Степан iванович, 2001 року народження, мiсце проживання м. Суми";
            string t2Text = "Комар Сергiй Федорович, 2000 року народження, мiсце проживання м. Київ";

            File.WriteAllText(t1FilePath, t1Text);
            File.WriteAllText(t2FilePath, t2Text);

            // Task3
            string t3FilePath = Path.Combine(folder2Path, "t3.txt");

            File.AppendAllText(t3FilePath, File.ReadAllText(t1FilePath));
            File.AppendAllText(t3FilePath, File.ReadAllText(t2FilePath));

            // Task4
            PrintFileInfo(t1FilePath);
            PrintFileInfo(t2FilePath);
            PrintFileInfo(t3FilePath);
            // Task5
            string movet2FilePath = Path.Combine(folder2Path, "t2.txt");
            if (File.Exists(movet2FilePath))
            {
                File.Delete(movet2FilePath); // Удаляем существующий файл
            }
            File.Move(t2FilePath, movet2FilePath); // Перемещаем файл

            // Task6
            string moveT1FilePath = Path.Combine(folder2Path, "t1.txt");
            File.Copy(t1FilePath, moveT1FilePath, true); // Перезаписываем существующий файл

            // Task7
            string allFolderPath = $"C:\\temp\\ALL";
            if (Directory.Exists(allFolderPath))
            {
                Directory.Delete(allFolderPath, true); // Удаляем существующую папку
            }
            Directory.Move(folder2Path, allFolderPath);
            Directory.Delete(folder1Path, true);

            // Task8
            Console.WriteLine("\nFiles in ALL directory:");
            string[] filesInAll = Directory.GetFiles(allFolderPath);
            foreach (string file in filesInAll)
            {
                PrintFileInfo(file);
            }
        }
    }
}


