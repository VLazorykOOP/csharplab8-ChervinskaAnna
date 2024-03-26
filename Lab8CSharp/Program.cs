using System;
using System.IO;
using System.Text.RegularExpressions;


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

            string outputFilePath = "output.txt";
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

        static void task3()
        {
            Console.Write("Task 3");

        }
        static void task4()
        {
            Console.Write("Task 4");

        }
        static void task5()
        {
            Console.Write("Task 5");

        }
    }
}
