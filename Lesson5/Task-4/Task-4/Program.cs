using System;
using System.IO;

/*
Сохранить дерево каталогов и файлов по заданному пути в текстовый файл — с
рекурсией и без.
*/

namespace Task_4
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Введите путь:");

            string pathUser = Console.ReadLine();

            Console.WriteLine(@"Через рекурсию или нет? Y\N");
            string recursionUser = Console.ReadLine();

            //Условие на проверку, каким образом нужно вывести файлы. Без рекурсии - с помощью метода из урока
            if (recursionUser.ToUpper() == "N")
            {
                WriteAllFiles(pathUser);
            }
            // С рекурсией
            else if (recursionUser.ToUpper() == "Y")
            {
                GetFilesFromDirectories(pathUser);
            }
            else
            {
                Console.WriteLine("Ошибка ввода");
            }

            Console.ReadKey();
        }

        //Метод вывода всех путей файлов на экран
        static void WriteAllFiles(string _path)
        {
            string[] resultFiles = Directory.GetFileSystemEntries(_path, "*", SearchOption.AllDirectories);

            foreach (string s in resultFiles)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine($"Всего выведено файлов: {resultFiles.Length}.");
        }


        //Метод по поиску файлов в подпапках с рекурсией
        static void GetFilesFromDirectories(string _path)
        {
            string[] resultFiles = Directory.GetFiles(_path);

            foreach (string s in resultFiles)
            {
                Console.WriteLine(s);
            }

            string[] resultDirectories = Directory.GetDirectories(_path);

            foreach (string s in resultDirectories)
            {
               GetFilesFromDirectories(s);
            }
        }
    }
}
