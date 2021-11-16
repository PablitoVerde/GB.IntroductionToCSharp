using System;
using System.IO;

/*
 * Написать программу,которая при старте дописывает текущее время в файл
«startup.txt».
*/

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateLog = DateTime.Now.ToString();

            string directoryLog = Directory.GetCurrentDirectory() + @"\startup.txt";

            File.AppendAllText(directoryLog, dateLog);
            File.AppendAllText(directoryLog, Environment.NewLine);

            Console.WriteLine("Добро пожаловать! Программа уже записала время запуска в лог.");

            Console.ReadKey();
        }
    }
}
