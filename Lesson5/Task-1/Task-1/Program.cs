using System;
using System.IO;

/*
 * Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.
 */

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст");
            string userInput = Console.ReadLine();

            string fileOutput = Directory.GetCurrentDirectory() + @"\useroutput.txt";

            File.AppendAllText(fileOutput, userInput);

            Console.WriteLine($"Данные добавлены в файл. Путь: {fileOutput}");

            Console.ReadKey();

        }
    }
}
