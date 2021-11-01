using System;

// Определить, является ли введённое пользователем число чётным.

// Пояснения. Чётность в теории чисел — характеристика целого числа, определяющая его способность делиться нацело на два, включая ноль.

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет! Давай проверим твое число на четность?");

            while (true)
            {
                Console.Write("Введи число: ");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (userNumber % 2 == 0)
                {
                    Console.WriteLine($"{userNumber} - четное число.");
                }
                else
                {
                    Console.WriteLine($"{userNumber} - нечетное число.");
                }

                Console.WriteLine("Хочешь продолжить? y/n");
                string userAnswer = Console.ReadLine();
                if (userAnswer == "n")
                {
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
