using System;
using System.Diagnostics;


/*
 * Написать консольное приложение Task Manager, которое выводит на экран запущенные процессы и
позволяет завершить указанный процесс. Предусмотреть возможность завершения процессов с
помощью указания его ID или имени процесса. В качестве примера можно использовать консольные
утилиты Windows tasklist и taskkill.
 */
namespace Task_1
{
    class Program
    {
        static void Main()
        {
            bool showmenu = true;

            while (showmenu)
            {
                Console.Clear();

                Console.WriteLine("Task-менеджер");

                Process[] process = Process.GetProcesses();

                foreach (Process p in process)
                {
                    Console.WriteLine($"{p.Id} {p.ProcessName}");
                }

                Console.WriteLine("Введите ID процесса или имя для его завершения.");
                string userSelection = Console.ReadLine();
                int processID = 0;

                try
                {
                    processID = Convert.ToInt32(userSelection);

                    foreach (Process p in process)
                    {
                        if (p.Id == processID)
                        {
                            p.Kill();
                        }
                    }
                }
                catch
                {
                    foreach (Process p in process)
                    {
                        if (p.ProcessName.ToUpper() == userSelection.ToUpper())
                        {
                            p.Kill();
                        }
                    }
                }
                finally
                {
                    Console.WriteLine(@"После хотите продолжить? N\Y"); ;
                    string s = Console.ReadLine();
                    
                    if (s.ToUpper() == "N")
                    {
                        showmenu = false;
                    }
                }
            }
        }
    }
}
