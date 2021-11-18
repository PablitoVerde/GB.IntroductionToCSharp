using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Написать любое приложение, произвести его сборку с помощью MSBuild, осуществить
декомпиляцию с помощью dotPeek, внести правки в программный код и пересобрать
приложение.
*/

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введи число: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            if (userNumber % 2 == 0)
            {
                Console.WriteLine("Делится");
            }
            else
            {
                Console.WriteLine("Не делится");
            }

            Console.ReadKey();
        }
    }
}
